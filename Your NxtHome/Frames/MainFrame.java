package Frames;

import java.lang.*;
import javax.swing.*;
import java.awt.event.*;
import java.awt.*;
public class MainFrame extends JFrame implements MouseListener
{
	JLabel lbl1,lbl2,lbl3,lbl4,lbl5,lbl6,lbl7,imglbl,btnlbl1,btnlbl2,btnlbl3;
	Color captionclr,brndnmclr;
	Font fnt1,fnt2;
	ImageIcon img;
	JPanel panel;
	
	public MainFrame()
	{
		super("Your NxtHome");
		this.setSize(1326,744);
		this.setLocationRelativeTo(null);
		panel=new JPanel();
		panel.setLayout(null);
		
		fnt1= new Font("Comic Sans MS",Font.BOLD | Font.ITALIC,60);
		fnt2= new Font("Aptos Black",Font.BOLD,32);
		captionclr=new Color(0,3,100);
		brndnmclr=new Color(23,59,11);
		
		lbl1=new JLabel("List it.");
		lbl1.setBounds(110,150,480,100);
		lbl1.setFont(fnt1);
		lbl1.setForeground(captionclr);
		panel.add(lbl1);
		
		lbl2=new JLabel("Find it.");
		lbl2.setBounds(110,220,480,100);
		lbl2.setFont(fnt1);
		lbl2.setForeground(captionclr);
		panel.add(lbl2);
		
		lbl3=new JLabel("Live in it.");
		lbl3.setBounds(110,290,480,100);
		lbl3.setFont(fnt1);
		lbl3.setForeground(captionclr);
		panel.add(lbl3);
		
		lbl4=new JLabel("your NxtHome");
		lbl4.setBounds(110,360,480,100);
		lbl4.setFont(fnt1);
		lbl4.setForeground(brndnmclr);
		panel.add(lbl4);
		
		lbl5=new JLabel("makes");
		lbl5.setBounds(110,430,480,100);
		lbl5.setFont(fnt1);
		lbl5.setForeground(captionclr);
		panel.add(lbl5);
		
		lbl6=new JLabel("Renting Easy");
		lbl6.setBounds(110,500,480,100);
		lbl6.setFont(fnt1);
		lbl6.setForeground(captionclr);
		panel.add(lbl6);
		
		lbl7=new JLabel("For everyone.");
		lbl7.setBounds(110,570,480,100);
		lbl7.setFont(fnt1);
		lbl7.setForeground(captionclr);
		panel.add(lbl7);
		
		btnlbl1=new JLabel("ABOUT");
		btnlbl1.setBounds(640,80,120,80);
		btnlbl1.setFont(fnt2);
		btnlbl1.setForeground(captionclr);
		btnlbl1.addMouseListener(this);
		panel.add(btnlbl1);
		
		btnlbl2=new JLabel("SIGN IN");
		btnlbl2.setBounds(800,80,140,80);
		btnlbl2.setFont(fnt2);
		btnlbl2.setForeground(captionclr);
		btnlbl2.addMouseListener(this);
		panel.add(btnlbl2);
		
		btnlbl3=new JLabel("SUPPORT US");
		btnlbl3.setBounds(955,80,250,80);
		btnlbl3.setFont(fnt2);
		btnlbl3.setForeground(captionclr);
		btnlbl3.addMouseListener(this);
		panel.add(btnlbl3);
		
		
		img=new ImageIcon("Image/page1.PNG");
		imglbl=new JLabel(img);
		imglbl.setBounds(0,0,1326,744);
		panel.add(imglbl);
		
		
		
		
		this.add(panel);
		
	}
	public void mouseClicked(MouseEvent me)
	{
	 if(me.getSource()==btnlbl2)
		{
			this.setVisible(false);
			Signin s1=new Signin();
			s1.setVisible(true);
		}
		else if(me.getSource()==btnlbl1)
		{
			this.setVisible(false);
			About a1=new About();
			a1.setVisible(true);
		}	
		else if(me.getSource()==btnlbl3)
		{
			this.setVisible(false);
			Support sp1=new Support();
			sp1.setVisible(true);
		}
	}
	public void mousePressed(MouseEvent me){}
	public void mouseReleased(MouseEvent me){}
	public void mouseEntered(MouseEvent me)
	{
		if(me.getSource()==btnlbl1)
		{
			btnlbl1.setForeground(Color.WHITE);
		}
		else if(me.getSource()==btnlbl2)
		{
			btnlbl2.setForeground(Color.WHITE);
		} 
		else if(me.getSource()==btnlbl3)
		{
			btnlbl3.setForeground(Color.WHITE);
		}
		
	}
	public void mouseExited(MouseEvent me)
	{
		if(me.getSource()==btnlbl1)
		{
			btnlbl1.setForeground(captionclr);
		}
		else if(me.getSource()==btnlbl2)
		{
			btnlbl2.setForeground(captionclr);
		}
		
		else if(me.getSource()==btnlbl3)
		{
			btnlbl3.setForeground(captionclr);
		}
	}
}