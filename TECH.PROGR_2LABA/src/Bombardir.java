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

              g.drawLine(startPosX + 20, startPosY + 40, startPosX + 105, startPosY + 40);
              g.drawLine(startPosX + 105, startPosY + 40, startPosX + 125, startPosY + 50);
              g.drawLine(startPosX + 125, startPosY + 50, startPosX + 105, startPosY + 60);
              g.drawLine(startPosX + 105, startPosY + 60, startPosX + 20, startPosY + 60);
              g.drawLine(startPosX + 20, startPosY + 60, startPosX + 20, startPosY + 40);
          }

			if(right)
			{
			g.setColor(dopColor);

              g.drawLine(startPosX + 20, startPosY + 145, startPosX + 105, startPosY + 145);
              g.drawLine(startPosX + 105, startPosY + 145, startPosX + 125, startPosY + 155);
              g.drawLine(startPosX + 125, startPosY + 155, startPosX + 105, startPosY + 165);
              g.drawLine(startPosX + 105, startPosY + 165, startPosX + 20, startPosY + 165);
              g.drawLine(startPosX + 20, startPosY + 165, startPosX + 20, startPosY + 145);
          }
		}
	
}
