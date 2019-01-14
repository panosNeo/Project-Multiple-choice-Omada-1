using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lucene.Net;
using Lucene.Net.Analysis;
using Lucene.Net.Analysis.Standard;
using Lucene.Net.Documents;
using Lucene.Net.Index;
using Lucene.Net.QueryParsers;
using Lucene.Net.Search;
using Lucene.Net.Store;

namespace QuizMaker.SearchHandler
{
    
    public class LuceneSearcher 
    {
        private Directory directory;
        private Analyzer analyser;
        private IndexWriter indexWriter;
        QueryParser parser;
        Query query;
        List<RetreivedQuiz> quiz;

        public LuceneSearcher(string path)
        {
            directory = FSDirectory.Open(path);
            analyser = new StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_CURRENT);
            indexWriter = new IndexWriter(directory,analyser, true, new IndexWriter.MaxFieldLength(100));
            GetAllQuizes();
            BuildIndex(quiz);
        }

        private void GetAllQuizes()
        {
            quiz = new List<RetreivedQuiz>();
            MultipleChoiceDataSetTableAdapters.QuizTableAdapter q = new MultipleChoiceDataSetTableAdapters.QuizTableAdapter();
            MultipleChoiceDataSetTableAdapters.SubjectTableAdapter sub = new MultipleChoiceDataSetTableAdapters.SubjectTableAdapter();
            MultipleChoiceDataSetTableAdapters.QuestionTableAdapter ques = new MultipleChoiceDataSetTableAdapters.QuestionTableAdapter();
            foreach(MultipleChoiceDataSet.QuizRow row in q.GetData())
            {
                quiz.Add(new RetreivedQuiz(row.Quiz_id,row.Title, sub.GetSubjectName(row.Subject_id),(int)ques.countQuestions(row.Quiz_id)));
                Console.WriteLine(quiz.Last<RetreivedQuiz>().ToString());
            }
        }
        public void BuildIndex(IEnumerable<RetreivedQuiz> dataToIndex)
        {
            foreach (var q in dataToIndex)
            {
                Document doc = new Document();
                doc.Add(new Field("Quiz_id",q.quizID.ToString(),
                Field.Store.YES,
                Field.Index.NO));
                doc.Add(new Field("Title",
                q.quizName,
                Field.Store.YES,
                Field.Index.ANALYZED));
                doc.Add(new Field("Subject",
                q.quizSubject,
                Field.Store.YES,
                Field.Index.ANALYZED));
                doc.Add(new Field("Questions",
                q.questionsCount.ToString(),
                Field.Store.YES,
                Field.Index.ANALYZED));
                Console.WriteLine(doc.ToString());
                indexWriter.AddDocument(doc);
            }
            
            indexWriter.Optimize();
            //indexWriter.Flush(true,true,true);
            indexWriter.Commit();
            indexWriter.Dispose();
            parser = new QueryParser(Lucene.Net.Util.Version.LUCENE_CURRENT, "", analyser);
            
        }

        public List<RetreivedQuiz> GetQuizzes(string q)
        {
            List<RetreivedQuiz> ret = new List<RetreivedQuiz>();
            
            using (Analyzer analyzerStandard = new Lucene.Net.Analysis.Standard.StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_29))
            {
                QueryParser parser = new QueryParser(Lucene.Net.Util.Version.LUCENE_CURRENT,"", analyzerStandard);
                using (IndexSearcher indexSearcher = new IndexSearcher(directory, true))
                {
                    var query = parser.Parse("Title:"+q+"*");
                    TopDocs result = indexSearcher.Search(query, 20);
                    Console.WriteLine("N° results in index:" + result.TotalHits);
                    for (int i = 0; i < result.ScoreDocs.Length; i++)
                    {
                        var score = result.ScoreDocs[i].Score;
                        Document doc = indexSearcher.Doc(result.ScoreDocs[i].Doc);
                        var Id = doc.Get("Id");
                        Console.WriteLine("Match id " + Id + " score " + score);
                        ret.Add(new RetreivedQuiz(Convert.ToInt32(doc.Get("Quiz_id")), doc.Get("Title"), doc.Get("Subject"), Convert.ToInt32(doc.Get("Questions"))));
                    }
                }
            }
            return ret;
        }
        
    }
}
