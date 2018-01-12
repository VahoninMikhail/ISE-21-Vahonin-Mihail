import java.awt.Color;
import java.awt.EventQueue;
import java.awt.Graphics;

import javax.swing.JColorChooser;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JTextField;
import javax.swing.JLabel;
import javax.swing.JButton;
import javax.swing.JCheckBox;

import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

import javax.swing.JTextPane;


public class Form1 
{
	private JFrame frame;
	private JTextField FMaxSpeed;
	private JTextField FWeight;
	private JTextField FMaxCountBomb;
	Color color;
	Color dopcolor;
	int maxSpeed;
	int maxCountBomb;
	int weight;

	Boolean left = false;
	Boolean right = false;
	
	private ITechnique inter;
	private JTextField MaxSpeed;
	private JTextField MaxCountBomb;
	private JTextField Weight;

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
	public Form1() 
	{
		color = Color.BLACK;
		dopcolor = Color.RED;
		maxSpeed = 150;
		maxCountBomb = 4;
		weight = 1500;
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(0, 0, 781, 512);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);

		JPanel panel = new JPanel();
		panel.setBounds(0, 0, 765, 379);
		frame.getContentPane().add(panel);
		
		JLabel lblNewLabel = new JLabel("Max Speed:");
		lblNewLabel.setBounds(10, 397, 75, 20);
		frame.getContentPane().add(lblNewLabel);
		
		JLabel lblNewLabel_1 = new JLabel("Max Count Bomb:");
		lblNewLabel_1.setBounds(10, 424, 88, 14);
		frame.getContentPane().add(lblNewLabel_1);
		
		JLabel lblNewLabel_2 = new JLabel("Weight:");
		lblNewLabel_2.setBounds(182, 400, 46, 14);
		frame.getContentPane().add(lblNewLabel_2);
		
		JCheckBox checkBox1 = new JCheckBox("\u041B\u0435\u0432\u044B\u0439");
		checkBox1.setBounds(182, 420, 68, 23);
		frame.getContentPane().add(checkBox1);
		
		JCheckBox checkBox2 = new JCheckBox("\u041F\u0440\u0430\u0432\u044B\u0439");
		checkBox2.setBounds(252, 420, 75, 23);
		frame.getContentPane().add(checkBox2);
		
		//кнопки с цветом
		JButton button1 = new JButton("\u0426\u0432\u0435\u0442");
		button1.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Color initialBackground = button1.getForeground();
				Color foreground = JColorChooser.showDialog(null,
						"JColorChooser Sample", initialBackground);
				if (foreground != null) {
					button1.setForeground(foreground);
				}
				color = foreground;
			}
		});
		button1.setBounds(331, 396, 75, 23);
		frame.getContentPane().add(button1);
		
		JButton button2 = new JButton("\u0414\u043E\u043F. \u0446\u0432\u0435\u0442");
		button2.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {

				Color initialBackground = button2.getForeground();
				Color foreground = JColorChooser.showDialog(null,
						"JColorChooser Sample", initialBackground);
				if (foreground != null) {
					button2.setForeground(foreground);
				}
				dopcolor = foreground;
			}
		});
		button2.setBounds(333, 440, 83, 23);
		frame.getContentPane().add(button2);
		
		//движение вверх
		JButton buttonUpMove = new JButton("\u0412\u0437\u043B\u0435\u0442");
		buttonUpMove.addActionListener(new ActionListener() {
		    public void actionPerformed(ActionEvent e) {
		        if (inter != null) {
			     Graphics gr = panel.getGraphics();
			     gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());
			     inter.moveUpBombardir(gr);
                }
		    }
		});
		buttonUpMove.setBounds(534, 396, 89, 23);
		frame.getContentPane().add(buttonUpMove);
		
		//бомбы
		JButton ButtonBomb = new JButton("\u0421\u0431\u0440\u043E\u0441\u0438\u0442\u044C \u0431\u043E\u043C\u0431\u0443");
		ButtonBomb.addActionListener(new ActionListener() {
		    public void actionPerformed(ActionEvent e) {
	            if (checkFields())
	            {
	            	 inter = new Bombardir(maxSpeed, maxCountBomb, weight, color, left, right, dopcolor);
	            	 Graphics gr = panel.getGraphics();
	                 inter.giveBomb(gr);
	            }
		    }
		});
		ButtonBomb.setBounds(633, 396, 122, 23);
		frame.getContentPane().add(ButtonBomb);
		
		//задать бомбардировщик
		JButton ButtonSetBombardir = new JButton("\u0417\u0430\u0434\u0430\u0442\u044C \u0431\u043E\u043C\u0431\u0430\u0440\u0434\u0438\u0440\u043E\u0432\u0449\u0438\u043A");
		ButtonSetBombardir.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (checkFields()) {
					left = checkBox1.isSelected();
					right = checkBox2.isSelected();
					inter = new Bombardir(maxSpeed, maxCountBomb, weight, color, left, right, dopcolor);
					Graphics gr = panel.getGraphics();
					gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());
	                inter.drawBombardir(gr);
				}
			}
		});
		ButtonSetBombardir.setBounds(590, 440, 165, 23);
		frame.getContentPane().add(ButtonSetBombardir);
		
		//задать самолет
		JButton Transport = new JButton("\u0417\u0430\u0434\u0430\u0442\u044C \u0441\u0430\u043C\u043E\u043B\u0435\u0442");
		Transport.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (checkFields()) {
				 inter = new Plane(maxSpeed, maxCountBomb, weight, color);
				 Graphics gr = panel.getGraphics();
				 gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());
				 inter.drawBombardir(gr);
				}
			}
		});
		Transport.setBounds(449, 440, 118, 23);
		frame.getContentPane().add(Transport);
		
		//движение
		JButton buttonMove = new JButton("\u0414\u0432\u0438\u0436\u0435\u043D\u0438\u0435");
		buttonMove.addActionListener(new ActionListener() {
		    public void actionPerformed(ActionEvent e) {
		        if (inter != null) {
			     Graphics gr = panel.getGraphics();
			     gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());
			     inter.moveBombardir(gr);
                }
		    }
		});
		buttonMove.setBounds(423, 396, 89, 23);
		frame.getContentPane().add(buttonMove);
		
		FMaxSpeed = new JTextField();
		FMaxSpeed.setBounds(97, 397, 68, 20);
		frame.getContentPane().add(FMaxSpeed);
		FMaxSpeed.setColumns(10);
		
		FMaxCountBomb = new JTextField();
		FMaxCountBomb.setBounds(97, 421, 69, 20);
		frame.getContentPane().add(FMaxCountBomb);
		FMaxCountBomb.setColumns(10);
		
		FWeight = new JTextField();
		FWeight.setBounds(223, 397, 75, 20);
		frame.getContentPane().add(FWeight);
		FWeight.setColumns(10);

	
        }
	private static boolean isDigit(String s) throws NumberFormatException {
		try {
			Integer.parseInt(s);
			return true;
		} catch (NumberFormatException e) {
			return false;
		}
	}
	
	private boolean checkFields() {
		if (isDigit(FMaxSpeed.getText())) {
			maxSpeed = Integer.parseInt(FMaxSpeed.getText());
		}

		if (isDigit(FMaxCountBomb.getText())) {
			maxCountBomb = Integer.parseInt(FMaxCountBomb.getText());
		}

		if (isDigit(FWeight.getText())) {
			weight = Integer.parseInt(FWeight.getText());
		}

		if (isDigit(FMaxSpeed.getText())) {
			maxSpeed = Integer.parseInt(FMaxSpeed.getText());
		}
         return true;
	}
}
