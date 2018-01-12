import java.awt.AWTException;
import java.awt.Cursor;
import java.awt.EventQueue;
import java.awt.Graphics;
import java.awt.Robot;
import javax.swing.JFrame;
import javax.swing.JLabel;
import java.awt.Font;
import javax.swing.JPanel;
import javax.swing.JButton;
import java.awt.Color;
import java.awt.datatransfer.DataFlavor;
import java.awt.datatransfer.Transferable;
import java.awt.datatransfer.UnsupportedFlavorException;
import java.awt.dnd.DnDConstants;
import java.awt.dnd.DragGestureEvent;
import java.awt.dnd.DragGestureListener;
import java.awt.dnd.DragSource;
import java.awt.dnd.DropTarget;
import java.awt.dnd.DropTargetAdapter;
import java.awt.dnd.DropTargetDropEvent;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import java.awt.event.MouseEvent;

import javax.swing.JTextField;

public class FormSelectColor implements DragGestureListener {
	int X;
	int Y;
	JFrame frame;
	JPanel pictureBoxPlane;
	ITechnique plane = null;
	boolean bBeginDrag = false;
	Boolean MouseIn = false;
	Boolean MouseColorBASE = false;
	Boolean MouseColorDOP = false;
	JLabel FCPlane;
	JLabel FCBombardir;
	private JTextField txtPlane;
	private JTextField txtBombardir;
	Color chooseColor;
	JLabel FBaseColor;
	JLabel FDopColor;

	public ITechnique getPlane() {
		return plane;
	}

	private void drawTechnique() {
		if (plane != null) {
			Graphics gr = pictureBoxPlane.getGraphics();
			gr.clearRect(0, 0, pictureBoxPlane.getWidth(),
					pictureBoxPlane.getHeight());
			plane.setPosition(100, 100);
			plane.drawBombardir(gr);
		}
	}
	
	public void ChooseColor(MouseEvent e) {
		try {
			Robot robot = new Robot();
			chooseColor = robot.getPixelColor(e.getX(), e.getY());
			System.out.println("Red   = " + chooseColor.getRed());
			System.out.println("Green = " + chooseColor.getGreen());
			System.out.println("Blue  = " + chooseColor.getBlue());
		} catch (AWTException ex) {
			System.err.println(ex.getMessage() + " выбор цвета");
			System.exit(0);
		}
	}

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					FormSelectColor window = new FormSelectColor();
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
	public FormSelectColor() {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {

		frame = new JFrame();
		frame.setBounds(100, 100, 970, 689);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);

		pictureBoxPlane = new JPanel();
		pictureBoxPlane.setBackground(Color.WHITE);
		pictureBoxPlane.setBounds(263, 60, 299, 301);
		frame.getContentPane().add(pictureBoxPlane);

		JButton FCOk = new JButton("OK");
		FCOk.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				Form1.frame.setVisible(true);
				Form1.close=true;
			}
		});
		FCOk.setBounds(54, 341, 115, 29);
		frame.getContentPane().add(FCOk);

		JButton FCancel = new JButton("Cancel");
		FCancel.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				
			}
		});
		FCancel.setBounds(60, 431, 115, 29);
		frame.getContentPane().add(FCancel);

		FBaseColor = new JLabel("Base Color");
		FBaseColor.setFont(new Font("Tahoma", Font.PLAIN, 20));
		FBaseColor.setBounds(356, 366, 121, 77);
		frame.getContentPane().add(FBaseColor);

		FDopColor = new JLabel("Dop Color");
		FDopColor.setFont(new Font("Tahoma", Font.PLAIN, 20));
		FDopColor.setBounds(790, 215, 121, 77);
		frame.getContentPane().add(FDopColor);

		JPanel panelRed = new JPanel();
		panelRed.setBackground(Color.RED);
		panelRed.setBounds(683, 109, 46, 40);
		frame.getContentPane().add(panelRed);

		JPanel panelOrange = new JPanel();
		panelOrange.setBackground(Color.ORANGE);
		panelOrange.setBounds(683, 148, 46, 40);
		frame.getContentPane().add(panelOrange);

		JPanel panelYellow = new JPanel();
		panelYellow.setBackground(Color.YELLOW);
		panelYellow.setBounds(683, 188, 46, 40);
		frame.getContentPane().add(panelYellow);

		JPanel panelGreen = new JPanel();
		panelGreen.setBackground(Color.GREEN);
		panelGreen.setBounds(683, 228, 46, 40);
		frame.getContentPane().add(panelGreen);

		JPanel panelLightBlue = new JPanel();
		panelLightBlue.setBackground(Color.CYAN);
		panelLightBlue.setBounds(729, 228, 46, 40);
		frame.getContentPane().add(panelLightBlue);

		JPanel panelBlue = new JPanel();
		panelBlue.setBackground(Color.BLUE);
		panelBlue.setBounds(729, 188, 46, 40);
		frame.getContentPane().add(panelBlue);

		JPanel panelFiol = new JPanel();
		panelFiol.setBackground(Color.MAGENTA);
		panelFiol.setBounds(729, 148, 46, 40);
		frame.getContentPane().add(panelFiol);

		JPanel panelBlack = new JPanel();
		panelBlack.setBackground(Color.BLACK);
		panelBlack.setBounds(729, 109, 46, 40);
		frame.getContentPane().add(panelBlack);

		txtPlane = new JTextField();
		txtPlane.setEditable(false);
		txtPlane.setText("Plane");
		txtPlane.setBounds(45, 76, 146, 26);
		frame.getContentPane().add(txtPlane);
		txtPlane.setColumns(10);
		txtPlane.setDragEnabled(true);

		txtBombardir = new JTextField();
		txtBombardir.setEditable(false);
		txtBombardir.setText("Bombardir");
		txtBombardir.setBounds(34, 242, 146, 26);
		frame.getContentPane().add(txtBombardir);
		txtBombardir.setColumns(10);
		txtBombardir.setDragEnabled(true);

		 new MyDropTargetListenerOBJECT(pictureBoxPlane);
		DragSource Plane = new DragSource();
		Plane.createDefaultDragGestureRecognizer(txtPlane,
				DnDConstants.ACTION_COPY, this);
		DragSource Bombardir = new DragSource();
		Bombardir.createDefaultDragGestureRecognizer(txtBombardir,
				DnDConstants.ACTION_COPY, this);

		new MyDropTargetListener(FBaseColor);
		new MyDropTargetListener(FDopColor);

		DragSource r = new DragSource();
		r.createDefaultDragGestureRecognizer(panelRed,
				DnDConstants.ACTION_COPY, this);
		DragSource o = new DragSource();
		o.createDefaultDragGestureRecognizer(panelOrange,
				DnDConstants.ACTION_COPY, this);
		DragSource y = new DragSource();
		y.createDefaultDragGestureRecognizer(panelYellow,
				DnDConstants.ACTION_COPY, this);
		DragSource g = new DragSource();
		g.createDefaultDragGestureRecognizer(panelGreen,
				DnDConstants.ACTION_COPY, this);
		DragSource l = new DragSource();
		l.createDefaultDragGestureRecognizer(panelLightBlue,
				DnDConstants.ACTION_COPY, this);
		DragSource b = new DragSource();
		b.createDefaultDragGestureRecognizer(panelBlue,
				DnDConstants.ACTION_COPY, this);
		DragSource f = new DragSource();
		f.createDefaultDragGestureRecognizer(panelFiol,
				DnDConstants.ACTION_COPY, this);
		DragSource bl = new DragSource();
		bl.createDefaultDragGestureRecognizer(panelBlack,
				DnDConstants.ACTION_COPY, this);

	}

	public void dragGestureRecognized(DragGestureEvent event) {
		Cursor cursor = null;
		try{
		JPanel panel = (JPanel) event.getComponent();
		Color color = panel.getBackground();

		if (event.getDragAction() == DnDConstants.ACTION_COPY) {
			cursor = DragSource.DefaultCopyDrop;
		}

		event.startDrag(cursor, new TransferableColor(color));
		}catch(Exception e){
			JTextField panel = (JTextField) event.getComponent();
			String text=panel.getText();
			if (event.getDragAction() == DnDConstants.ACTION_COPY) {
				cursor = DragSource.DefaultCopyDrop;
			}

			event.startDrag(cursor, new TransferableText(text));
		}
	}

	class MyDropTargetListener extends DropTargetAdapter {

		private DropTarget dropTarget;
		private JLabel lable;

		public MyDropTargetListener(JLabel lab) {
			this.lable = lab;
			dropTarget = new DropTarget(lab, DnDConstants.ACTION_COPY, this,
					true, null);
		}

		public void drop(DropTargetDropEvent event) {
			if(lable==FDopColor){
				MouseColorDOP=true;
			}else MouseColorDOP=false;
			try {

				Transferable tr = event.getTransferable();
				Color color = (Color) tr
						.getTransferData(TransferableColor.colorFlavor);

				if (event.isDataFlavorSupported(TransferableColor.colorFlavor)) {

					event.acceptDrop(DnDConstants.ACTION_COPY);

					if (plane != null) {
						if (MouseColorDOP) {
							if (plane instanceof Bombardir) {
								((Bombardir) plane).setDopColor(color);
								drawTechnique();
							}
						} else
							plane.setMainColor(color);
						drawTechnique();
					}
					event.dropComplete(true);
					return;
				}
				event.rejectDrop();
			} catch (Exception e) {
				e.printStackTrace();
				event.rejectDrop();
			}
		}
	}
	class MyDropTargetListenerOBJECT extends DropTargetAdapter {

		private DropTarget dropTarget;
		private JPanel panel;

		public MyDropTargetListenerOBJECT(JPanel pan) {
			this.panel = pan;
			
			dropTarget = new DropTarget(pan, DnDConstants.ACTION_COPY, this,
					true, null);
		}

		public void drop(DropTargetDropEvent event) {
			try {

				Transferable tr = event.getTransferable();
				String text = (String)tr.getTransferData(TransferableText.textFlavor);

				if (event.isDataFlavorSupported(TransferableText.textFlavor)) {

					event.acceptDrop(DnDConstants.ACTION_COPY);

					switch (text) {
					case "Plane":
						plane = new Plane(100, 8, 500, Color.BLACK);
						break;
					case "Bombardir":
						plane = new Bombardir(100, 8, 500,
								Color.BLACK, true, true, Color.BLACK);
						break;
					}
					drawTechnique();
					event.dropComplete(true);
					return;
				}
				event.rejectDrop();
			} catch (Exception e) {
				e.printStackTrace();
				event.rejectDrop();
			}
		}
	}
}
class TransferableText implements Transferable {
	protected static DataFlavor textFlavor = new DataFlavor(String.class,
			"A text Object");

	protected static DataFlavor[] supportedFlavors = { textFlavor,
			DataFlavor.stringFlavor, };
	String str;
	public TransferableText(String t) {
		this.str = t;
	}
	@Override
	public Object getTransferData(DataFlavor flavor)
			throws UnsupportedFlavorException {
		if (flavor.equals(textFlavor))
			return str;
		else if (flavor.equals(DataFlavor.stringFlavor))
			return str.toString();
		else
			throw new UnsupportedFlavorException(flavor);
	
	}
	@Override
	public DataFlavor[] getTransferDataFlavors() {
		return supportedFlavors;
	}
	@Override
	public boolean isDataFlavorSupported(DataFlavor flavor) {
		if (flavor.equals(textFlavor)
				|| flavor.equals(DataFlavor.stringFlavor))
			return true;
		return false;
	}
}



class TransferableColor implements Transferable {

	protected static DataFlavor colorFlavor = new DataFlavor(Color.class,
			"A Color Object");

	protected static DataFlavor[] supportedFlavors = { colorFlavor,
			DataFlavor.stringFlavor, };

	Color color;

	public TransferableColor(Color color) {
		this.color = color;
	}

	public DataFlavor[] getTransferDataFlavors() {
		return supportedFlavors;
	}

	public boolean isDataFlavorSupported(DataFlavor flavor) {
		if (flavor.equals(colorFlavor)
				|| flavor.equals(DataFlavor.stringFlavor))
			return true;
		return false;
	}

	public Object getTransferData(DataFlavor flavor)
			throws UnsupportedFlavorException {
		if (flavor.equals(colorFlavor))
			return color;
		else if (flavor.equals(DataFlavor.stringFlavor))
			return color.toString();
		else
			throw new UnsupportedFlavorException(flavor);
	}
}