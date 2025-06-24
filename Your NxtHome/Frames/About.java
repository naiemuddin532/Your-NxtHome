package Frames;

import java.lang.*;
import javax.swing.*;
import java.awt.event.*;
import java.awt.*;
public class About extends JFrame implements MouseListener,ActionListener
{
	JLabel lbl1,lbl2,lbl3,lbl4,lbl5,imgabout,tmglbl,nmglbl;
	Color clr1;
	Font fnt1,fnt2;
	JButton bbtn;
	ImageIcon img,tmg,nmg;
	JPanel panel;
	public About()
	{
		super("Your NxtHome");
		this.setSize(1326,744);
		this.setLocationRelativeTo(null);
		panel=new JPanel();
		panel.setLayout(null);
		
		fnt1= new Font("sref",Font.PLAIN,24);
		fnt2= new Font("Comic Sans MS",Font.BOLD | Font.ITALIC,28);
		
		clr1=new Color(0,9,64);
		
		lbl1=new JLabel("<html>Your NxtHome is designed to solve a common problem in our country—<br>Many bachelors and job holders face challenges renting flats, as landlords often prefer families.<br>With Your NxtHome, there's no need to go door-to-door.<br>Just open our app or website to browse, filter, and book your ideal flat—quickly, easily, and completely free.</html>");
		lbl1.setBounds(100,80,999,300);
		lbl1.setFont(fnt1);
		lbl1.setForeground(clr1);
		panel.add(lbl1);
		
		lbl2=new JLabel("<html>Homeowners can list their flats, set requirements (like bachelor-friendly or not), and connect with the right tenants.<br>Tenants can find places that match their lifestyle and needs—without the usual stress.<br>Your NxtHome – Renting Made Simple.</html>");
		lbl2.setBounds(100,190,999,400);
		lbl2.setFont(fnt1);
		lbl2.setForeground(clr1);
		panel.add(lbl2);
		
		lbl3=new JLabel("<html>🛠️ Built with passion by:-");
		lbl3.setBounds(200,400,999,200);
		lbl3.setFont(fnt2);
		lbl3.setForeground(clr1);
		panel.add(lbl3);
		
		bbtn=new JButton("Back");
		bbtn.setBounds(650,615,150,60);
		bbtn.setBackground(Color.RED);
		bbtn.setFont(fnt2);
		bbtn.addMouseListener(this);
		bbtn.addActionListener(this);
		panel.add(bbtn);
		
		lbl4=new JLabel("<html><u>MD.Naiem Uddin</u></html>");
		lbl4.setBounds(400,500,280,80);
		lbl4.setFont(fnt2);
		lbl4.setForeground(Color.BLUE);
		lbl4.addMouseListener(this);
		panel.add(lbl4);
		
		lbl5=new JLabel("<html><u>Tajkiya Islam</u></html>");
		lbl5.setBounds(800,500,280,80);
		lbl5.setFont(fnt2);
		lbl5.setForeground(Color.BLUE);
		lbl5.addMouseListener(this);
		panel.add(lbl5);
		
		
		tmg=new ImageIcon("Image/tmg.PNG");
		tmglbl=new JLabel(tmg);
		tmglbl.setBounds(700,100,364,426);
		tmglbl.setVisible(false);
		panel.add(tmglbl);
		
		nmg=new ImageIcon("Image/nmg.PNG");
		nmglbl=new JLabel(nmg);
		nmglbl.setBounds(300,100,361,425);
		nmglbl.setVisible(false);
		panel.add(nmglbl);
		
		img=new ImageIcon("Image/About.PNG");
		imgabout=new JLabel(img);
		imgabout.setBounds(0,0,1326,744);
		panel.add(imgabout);
		this.add(panel);
	}
	public void mouseClicked(MouseEvent me){}
	public void mousePressed(MouseEvent me){}
	public void mouseReleased(MouseEvent me){}
	public void mouseEntered(MouseEvent me)
	{
		if(me.getSource()==bbtn)
		{
			bbtn.setForeground(Color.WHITE);
		}
		if(me.getSource()==lbl4)
		{
			nmglbl.setVisible(true);
			lbl1.setVisible(false);
			lbl2.setVisible(false);
			lbl3.setVisible(false);
			//lbl4.setVisible(false);
			lbl5.setVisible(false);
		}
		if(me.getSource()==lbl5)
		{
			tmglbl.setVisible(true);
			lbl1.setVisible(false);
			lbl2.setVisible(false);
			lbl3.setVisible(false);
			lbl4.setVisible(false);
			//lbl5.setVisible(false);
			
		}
	}
	public void mouseExited(MouseEvent me)
	{
		if(me.getSource()==bbtn)
		{
			bbtn.setForeground(Color.BLACK);
		}
		if(me.getSource()==lbl4)
		{
			nmglbl.setVisible(false);	
			lbl1.setVisible(true);
			lbl2.setVisible(true);
			lbl3.setVisible(true);
			//lbl4.setVisible(true);
			lbl5.setVisible(true);
		}
		if(me.getSource()==lbl5)
		{
			tmglbl.setVisible(false);	
			lbl1.setVisible(true);
			lbl2.setVisible(true);
			lbl3.setVisible(true);
			lbl4.setVisible(true);
			//lbl5.setVisible(true);
		}
	}
	public void actionPerformed(ActionEvent ae)
	{
		if(ae.getSource()==bbtn)
		{
			this.setVisible(false);
			MainFrame m1=new MainFrame();
			m1.setVisible(true);
		}
	}
}