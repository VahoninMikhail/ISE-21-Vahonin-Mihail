import java.awt.Color;
import java.awt.Graphics;

public abstract class Technique implements ITechnique
	{
	protected int startPosX;
	protected int startPosY;
	protected int countBomb;

	public abstract void moveBomb(Graphics g);
	
	public abstract void moveBombardir(Graphics g);
    public abstract void giveBomb(Graphics g);
    public abstract void moveUpBombardir(Graphics g);
    public abstract void drawBombardir(Graphics g);

	public void setPosition(int x, int y)
	{
		startPosX = x;
		startPosY = y;
	}
    
	private int MaxCountBomb;
	protected void SetMaxCountBomb(int m) {
		MaxCountBomb = m;
	}
	public int GetMaxCountBomb() {
		return MaxCountBomb;
	}
	
	private double MaxSpeed;
	protected void SetMaxSpeed(int s) {
		MaxSpeed = s;
	}
	public double GetMaxSpeed() {
		return MaxSpeed;
	}
	
	private int Weight;
	protected void SetWeight(int w) {
		Weight = w;
	}
	public int GetWeight() {
		return Weight;
	}

	private Color ColorBody;
	protected void SetColorBody(Color c) {
		ColorBody = c;
	}
	public Color GetColorBody() {
		return ColorBody;
	}
	
	public void loadBomb(int count)
	{
		if (countBomb + count < MaxCountBomb)
		{
			countBomb += count;
		}
	}

	public int getBomb()
	{
		int count = countBomb;
		countBomb = 0;
		return count;
	}
	
	}
	
