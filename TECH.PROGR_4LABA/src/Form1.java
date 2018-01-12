import java.awt.Color;
import java.awt.EventQueue;
import java.awt.Graphics;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

import javax.swing.JColorChooser;
import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JTextPane;
import javax.swing.JFormattedTextField;
import javax.swing.JTextField;
import javax.swing.JList;



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
	int SelectedIndex;
	String[] data;
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
		parking = new Parking(5);
		SelectedIndex = -1;
		data = new String[7];
		for (int i = 0; i < data.length; i++) {
			data[i] = "Уровень " + i;
		}
		initialize();
	}

	private void Draw(JPanel panel) {
		// 4
				if (parking.getCurrentLevel() > -1) {
					//
					Graphics gr = panel.getGraphics();
					gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());
					parking.Draw(gr, panel.getWidth(), panel.getHeight());
				}
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

		JList listBoxLevels = new JList(data);
		listBoxLevels.setBounds(717, 149, 146, 91);
		frame.getContentPane().add(listBoxLevels);
		listBoxLevels.setSelectedIndex(parking.getCurrentLevel());

		
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
		FSetPlane.setBounds(693, 57, 201, 29);
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
		FSetBombardir.setBounds(693, 97, 201, 29);
		frame.getContentPane().add(FSetBombardir);
		
		JLabel Number = new JLabel("Номер");
		Number.setBounds(717, 278, 39, 14);
		frame.getContentPane().add(Number);

		FTicket = new JTextField();
		FTicket.setBounds(670, 295, 137, 20);
		frame.getContentPane().add(FTicket);

		JPanel FPlane = new JPanel();
		FPlane.setBounds(670, 326, 264, 279);
		frame.getContentPane().add(FPlane);

		JButton FGet = new JButton("Get");
		FGet.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				// 4
				if (listBoxLevels.getSelectedIndex() > -1) {
					String level = listBoxLevels.getSelectedValue().toString();
					//
					if (FTicket.getText() != "") {
						ITechnique plane = parking.GetPlaneInParking(Integer
								.parseInt(FTicket.getText()));
						if (plane != null) {
							Graphics gr = FPlane.getGraphics();
							gr.clearRect(0, 0, FPlane.getWidth(),FPlane.getHeight());
							plane.setPosition(30, 30);
							plane.drawBombardir(gr);
							Draw(panel);
						}
					}
				}
			}
		});
		FGet.setBounds(829, 291, 115, 29);
		frame.getContentPane().add(FGet);

		JButton FStart = new JButton("Start");
		FStart.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				Draw(panel);
			}
		});
		FStart.setBounds(733, 17, 115, 29);
		frame.getContentPane().add(FStart);
		

		JButton buttonUp = new JButton("->");
		buttonUp.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				parking.LevelUp();
				listBoxLevels.setSelectedIndex(parking.getCurrentLevel());
				Draw(panel);
			}
		});
		buttonUp.setBounds(869, 181, 75, 29);
		frame.getContentPane().add(buttonUp);
		
		JButton buttonDown = new JButton("<-");
		buttonDown.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				parking.LevelDown();
				listBoxLevels.setSelectedIndex(parking.getCurrentLevel());
				Draw(panel);
			}
		});
		buttonDown.setBounds(632, 181, 75, 29);
		frame.getContentPane().add(buttonDown);
		}
}
