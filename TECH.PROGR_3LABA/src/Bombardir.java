import java.awt.Color;
import java.awt.Graphics;

public class Bombardir extends Plane {
	private boolean left;
	private boolean right;
    private Color dopColor;
    
	public Bombardir(int maxSpeed, int maxCountBomb, int weight, Color color, boolean left, boolean right, Color dopColor) 
	{
		super(maxSpeed, maxCountBomb, weight, color);
	
		this.left = left;
		this.right =right;
        this.dopColor = dopColor;
	}

	@Override
	protected void takeBomb(Graphics g)
    {
		g.setColor(Color.BLACK);
		for ( int i = 0; i<=20; i++)
		{
			g.drawLine(0, 0, 800+i*30, 800+i*30);
            g.drawLine(0, 0, 1200+i*30, 800+i*30);
            g.drawLine(1200+i*30, 0, 0, 500+i*30);
            g.drawLine(1100+i*30, 0, 0, 200+i*30);
            g.drawLine(1100+i*30, 0, 0, 200+i*30);
        }
    }
	
	@Override
    protected void drawLightBombardir(Graphics g)
		{
          super.drawLightBombardir(g);
			if(left)
			{
			g.setColor(dopColor);

              g.drawLine((startPosX + 20)/2, (startPosY + 40)/2, (startPosX + 105)/2, (startPosY + 40)/2);
              g.drawLine((startPosX + 105)/2, (startPosY + 40)/2, (startPosX + 125)/2, (startPosY + 50)/2);
              g.drawLine((startPosX + 125)/2, (startPosY + 50)/2, (startPosX + 105)/2, (startPosY + 60)/2);
              g.drawLine((startPosX + 105)/2, (startPosY + 60)/2, (startPosX + 20)/2, (startPosY + 60)/2);
              g.drawLine((startPosX + 20)/2, (startPosY + 60)/2, (startPosX + 20)/2, (startPosY + 40)/2);
          }

			if(right)
			{
			g.setColor(dopColor);

              g.drawLine((startPosX + 20)/2, (startPosY + 145)/2, (startPosX + 105)/2, (startPosY + 145)/2);
              g.drawLine((startPosX + 105)/2, (startPosY + 145)/2, (startPosX + 125)/2, (startPosY + 155)/2);
              g.drawLine((startPosX + 125)/2, (startPosY + 155)/2, (startPosX + 105)/2, (startPosY + 165)/2);
              g.drawLine((startPosX + 105)/2, (startPosY + 165)/2, (startPosX + 20)/2, (startPosY + 165)/2);
              g.drawLine((startPosX + 20)/2, (startPosY + 165)/2, (startPosX + 20)/2, (startPosY + 145)/2);
          }
		}
	
}
