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
	FormSelectColor window = null;
	static JFrame frame;
	JPanel panel;
	private JTextField FTicket;
	Matcher m;
	static Parking parking;
	Color color;
	Color dopcolor;
	int maxSpeed;
	int maxCountBomb;
	int weight;
	Boolean left = false;
	Boolean right = false;
	int SelectedIndex;
	String[] data;
	private static ITechnique inter;
	static boolean close=false;

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
		//5
				if(close){
					ITechnique plane = window.getPlane();
					if (plane != null) {
						parking.PutPlaneInParking(plane);
						panel.repaint();
						JOptionPane.showMessageDialog(frame, "готово");
						close=false;
					}
				}
		//
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
		
		JLabel Number = new JLabel("Номер");
		Number.setBounds(717, 278, 39, 14);
		frame.getContentPane().add(Number);

		FTicket = new JTextField();
		FTicket.setBounds(670, 295, 137, 20);
		frame.getContentPane().add(FTicket);
		
		JButton btnNewButton = new JButton("\u041E\u041A");
		btnNewButton.setBounds(733, 99, 115, 29);
		frame.getContentPane().add(btnNewButton);

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
		
		//5
		JButton btnOrder = new JButton("Order");
		btnOrder.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {	
				try {
					frame.setVisible(false);
					window = new FormSelectColor();
					window.frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}		
			}	
		});
		btnOrder.setBounds(733, 59, 115, 29);
		frame.getContentPane().add(btnOrder);
		//
		btnNewButton.addActionListener(new ActionListener() {

			@Override
			public void actionPerformed(ActionEvent e) {
				Pattern p = Pattern.compile("\\d");
				m = p.matcher(FTicket.getText());
				if (!m.matches()) {
					System.out.println("NO");
					FTicket.setText("");
				} else
					System.out.println("Yes");
			}
		});
	}

public  void AddPlane(ITechnique plane) {
		if (plane != null) {
			int place = parking.PutPlaneInParking(plane);
			System.out.println(place);
			if (place > -1) {
				Draw(panel);
				JOptionPane.showMessageDialog(frame, "Ваше место: " + place);
			} else {
				JOptionPane.showMessageDialog(frame,
						"мест нет");
			}
		}
	}

}
