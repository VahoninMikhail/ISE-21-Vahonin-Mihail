import java.awt.Color;
import java.awt.EventQueue;
import java.awt.Graphics;

import javax.swing.JColorChooser;
import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JTextField;
import javax.swing.JLabel;
import javax.swing.JButton;

import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import java.util.regex.Matcher;
import java.util.regex.Pattern;



public class Form1 
{
	private JFrame frame;
	private JTextField FTicket;
	Matcher m;
	Parking parking;
	Color color;
	Color dopcolor;
	int maxSpeed;
	int maxCountBomb;
	int weight;
	Boolean left = false;
	Boolean right = false;
	private ITechnique inter;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Form1 window = new Form1();
					window.frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public Form1() {
		color = Color.WHITE;
		dopcolor = Color.YELLOW;
		maxSpeed = 150;
		maxCountBomb = 4;
		weight = 1500;
		parking = new Parking();
		initialize();
	}

	private void Draw(JPanel panel) {
		Graphics gr = panel.getGraphics();
		gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());
		parking.Draw(gr, panel.getWidth(), panel.getHeight());
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {

		frame = new JFrame();
		frame.setBounds(100, 100, 970, 689);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);

		JPanel panel = new JPanel();
		panel.setBounds(10, 5, 603, 600);
		frame.getContentPane().add(panel);

		JButton FSetPlane = new JButton("\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C \u0441\u0430\u043C\u043E\u043B\u0435\u0442");
		FSetPlane.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {

				Color initialBackground = FSetPlane.getForeground();
				Color foreground = JColorChooser.showDialog(null,
						"JColorChooser Sample", initialBackground);
				color = foreground;

				inter = new Plane(100, 4, 1000, color);
				int place = parking.PutPlaneInParking(inter);
				Draw(panel);
				JOptionPane.showMessageDialog(frame, "Ваше место: " + place);
			}
		});
		FSetPlane.setBounds(693, 59, 201, 29);
		frame.getContentPane().add(FSetPlane);

		JButton FSetBombardir = new JButton("\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C \u0431\u043E\u043C\u0431\u0430\u0440\u0434\u0438\u0440\u043E\u0432\u0449\u0438\u043A");
		FSetBombardir.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				Color initialBackground = FSetPlane.getForeground();
				Color foreground = JColorChooser.showDialog(null,
						"JColorChooser Sample", initialBackground);
				color = foreground;

				Color initialBackground1 = FSetPlane.getForeground();
				Color foreground1 = JColorChooser.showDialog(null,
						"JColorChooser Sample", initialBackground1);
				dopcolor = foreground1;

				inter = new Bombardir(100, 4, 1000, color, true, true, dopcolor);
				int place = parking.PutPlaneInParking(inter);
				Draw(panel);
				JOptionPane.showMessageDialog(frame, "Ваше место: " + place);

			}
		});
		FSetBombardir.setBounds(693, 99, 201, 29);
		frame.getContentPane().add(FSetBombardir);

		JLabel Number = new JLabel("Number");
		Number.setBounds(768, 139, 69, 20);
		frame.getContentPane().add(Number);

		FTicket = new JTextField();
		FTicket.setBounds(678, 170, 238, 37);
		frame.getContentPane().add(FTicket);

		JPanel FPlane = new JPanel();
		FPlane.setBounds(659, 284, 264, 265);
		frame.getContentPane().add(FPlane);

		JButton FGet = new JButton("\u0417\u0430\u0431\u0440\u0430\u0442\u044C");
		FGet.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {

				if (FTicket.getText() != "") {
					ITechnique plane = parking.GetPlaneInParking(Integer
							.parseInt(FTicket.getText()));
					if (plane != null) {
						Graphics gr = FPlane.getGraphics();
						gr.clearRect(0, 0, FPlane.getWidth(),
								FPlane.getHeight());
						plane.setPosition(30, 30);
						plane.drawBombardir(gr);
						Draw(panel);
					}
				}
			}
		});
		FGet.setBounds(733, 244, 115, 29);
		frame.getContentPane().add(FGet);

		JButton FStart = new JButton("Start");
		FStart.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				Draw(panel);
			}
		});
		FStart.setBounds(733, 19, 115, 29);
		frame.getContentPane().add(FStart);
	}
}
