import java.awt.Color;
import java.awt.Graphics;
import java.util.Random;

public class Plane extends Technique {
	
	@Override
	public int GetMaxCountBomb()
	{
		return super.GetMaxCountBomb();
	}
	
	protected void SetMaxCountBomb(int value)
	{
		if (value > 0 && value < 5)
		{
			super.SetMaxCountBomb(value);
		}
		else
		{
			super.SetMaxCountBomb(4);
		}
	}
	
	@Override
	public double GetMaxSpeed()
	{
		return super.GetMaxSpeed();
	}
	@Override
	protected void SetMaxSpeed(int value)
	{
		if (value > 0 && value < 1500)
		{
			super.SetMaxSpeed(value);
		}
		else
		{
			super.SetMaxSpeed(1000);
		}
	}

	@Override
	public int GetWeight()
	{
		return super.GetWeight();
	}
	@Override
	protected void SetWeight(int value)
	{
		if(value > 500 && value < 1500)
		{
			super.SetWeight(value);
		}
		else
		{
			super.SetWeight(1000);
		}
	}

	public Plane(int maxSpeed, int maxCountBomb, int weight, Color color)
	{
		this.SetMaxSpeed(maxSpeed);
		this.SetMaxCountBomb(maxCountBomb);
		this.SetColorBody(color);
		this.SetWeight(weight);
		Random rand = new Random();
		startPosX = rand.nextInt(200);
		startPosY = rand.nextInt(200);
	}

	protected void drawLightBombardir(Graphics g)
	{
		g.setColor(GetColorBody());
		g.drawLine((startPosX + 25)/2, (startPosY + 20)/2, (startPosX + 40)/2, (startPosY + 20)/2);
        g.drawLine((startPosX + 40)/2, (startPosY + 20)/2, (startPosX + 130)/2, (startPosY + 95)/2);
        g.drawLine((startPosX + 130)/2, (startPosY + 95)/2, (startPosX + 130)/2, (startPosY + 110)/2);
        g.drawLine((startPosX + 130)/2, (startPosY + 110)/2, (startPosX + 40)/2, (startPosY + 190)/2);
        g.drawLine((startPosX + 40)/2, (startPosY + 190)/2, (startPosX + 25)/2, (startPosY + 190)/2);
        g.drawLine((startPosX + 25)/2, (startPosY + 190)/2, (startPosX + 80)/2, (startPosY + 110)/2);
        g.drawLine((startPosX + 80)/2, (startPosY + 110)/2, (startPosX + 80)/2, (startPosY + 95)/2);
        g.drawLine((startPosX + 80)/2, (startPosY + 95)/2, (startPosX + 25)/2, (startPosY + 20)/2);
    }

	@Override
	public void moveBombardir(Graphics g)
	{
		// TODO Auto-generated method stub
		startPosX += (GetMaxSpeed() * 50 / (float)GetWeight()) / (countBomb == 0 ? 1 : countBomb);
		drawBombardir(g);
	}

	@Override
    public void moveUpBombardir(Graphics g)
    {
        startPosY -= (GetMaxSpeed() * 50 / (float)GetWeight()) / (countBomb == 0 ? 1 : countBomb);
        drawBombardir(g);
    }
	
	@Override
    public void moveBomb(Graphics g)
    {
        throw new UnsupportedOperationException();
    }

	@Override
    public void giveBomb(Graphics g)
    {
        takeBomb(g);
    }

	@Override
    public void drawBombardir(Graphics g)
	{
		drawLightBombardir(g);
	}
	
    protected void takeBomb(Graphics g)
    {
        
    }
	
}
