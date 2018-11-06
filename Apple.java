
package com.fanis.eng;

import java.awt.Color;
import java.awt.Graphics;


public class Apple {
    private int xCoor, yCoor, width, height;
    public Apple(int xCoor, int yCoor, int tileSize){
        this.xCoor = xCoor;
        this.yCoor = yCoor;
        width = tileSize;
        height = tileSize;
    }
    
    public void draw(Graphics g)
    {
        g.setColor(Color.black);
        g.fillRect(xCoor * width, yCoor * height, width, height);
        g.setColor(Color.RED);
        g.fillRect(xCoor * width + 2, yCoor * height +2, width - 4, height - 4);
    }
    
    public void tick()
    {
        //vlado test 
    }
    
}
