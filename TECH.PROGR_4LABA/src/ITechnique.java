import java.awt.Graphics;

public interface ITechnique {
	void moveBombardir(Graphics g);

    void moveUpBombardir(Graphics g);

    void giveBomb(Graphics g);

    void moveBomb(Graphics g);

	void setPosition(int x, int y);

	void loadBomb(int count);

	int getBomb();
    void drawBombardir(Graphics gr);
}
