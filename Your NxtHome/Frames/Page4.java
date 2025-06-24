package Frames;

import java.lang.*;
import javax.swing.*;
import java.awt.event.*;
import java.awt.*;
public class Page4 extends JFrame implements MouseListener,ActionListener
{
	
	JLabel hdlbl,imglbl1;
	JButton bbtn,phbtn,vpbtn;
	Color captionclr,clr3;
	Font fnt1,fnt4,fnt2;
	ImageIcon img;
	JPanel panel;
	public Page4()
	{
		super("Your NxtHome");
		this.setSize(1326,746);
		this.setLocationRelativeTo(null);
		panel=new JPanel();
		panel.setLayout(null);
		
		fnt1= new Font("Comic Sans MS",Font.BOLD | Font.ITALIC,40);
		fnt2= new Font("Comic Sans MS",Font.BOLD | Font.ITALIC,28);
		fnt4= new Font("sref",Font.PLAIN,16);
		
		captionclr=new Color(0,3,100);
		clr3=new Color(58,8,62);
		
		hdlbl=new JLabel("Welcome! Your trust means everything to us.");
		hdlbl.setBackground(captionclr);
		hdlbl.setBounds(180,90,900,100);
		hdlbl.setFont(fnt1);
		panel.add(hdlbl);
		
		phbtn=new JButton("Add New Post");
		phbtn.setBounds(500,300,350,60);
		phbtn.setBackground(clr3);
		phbtn.setForeground(Color.WHITE);
		phbtn.setFont(fnt2);
		phbtn.addMouseListener(this);
		phbtn.addActionListener(this);
		panel.add(phbtn);
		
		vpbtn=new JButton("View Previous Post");
		vpbtn.setBounds(500,420,350,60);
		vpbtn.setBackground(captionclr);
		vpbtn.setForeground(Color.WHITE);
		vpbtn.setFont(fnt2);
		vpbtn.addMouseListener(this);
		vpbtn.addActionListener(this);
		panel.add(vpbtn);
		
		bbtn=new JButton("Back");
		bbtn.setBounds(600,550,100,40);
		bbtn.setBackground(Color.RED);
		bbtn.setForeground(Color.BLACK);
		bbtn.setFont(fnt2);
		bbtn.addMouseListener(this);
		bbtn.addActionListener(this);
		panel.add(bbtn);
		
		
		img=new ImageIcon("Image/page4.PNG");
		imglbl1=new JLabel(img);
		imglbl1.setBounds(0,0,1326,744);
		panel.add(imglbl1);
		this.add(panel);
	}
	public void mouseClicked(MouseEvent me){}
	public void mousePressed(MouseEvent me){}
	public void mouseReleased(MouseEvent me){}
	public void mouseEntered(MouseEvent me)
	{
		if(me.getSource()==phbtn)
		{
			phbtn.setBackground(Color.WHITE);
			phbtn.setForeground(Color.BLACK);
		}
		else if(me.getSource()==bbtn)
		{
			bbtn.setForeground(Color.WHITE);
		} 
		else if(me.getSource()==vpbtn)
		{
			vpbtn.setBackground(Color.WHITE);
			vpbtn.setForeground(Color.BLACK);
		}
		
	}
	public void mouseExited(MouseEvent me)
	{
		if(me.getSource()==phbtn)
		{
		phbtn.setBackground(clr3);
		phbtn.setForeground(Color.WHITE);
		}
		else if(me.getSource()==bbtn)
		{
		bbtn.setForeground(Color.WHITE);
		}
		
		else if(me.getSource()==vpbtn)
		{
		vpbtn.setBackground(captionclr);
		vpbtn.setForeground(Color.WHITE);
		}
	}
	public void actionPerformed(ActionEvent ae)
	{
		if(ae.getSource()==bbtn)
		{
			this.setVisible(false);
			Signin s1=new Signin();
			s1.setVisible(true);
		}
		if (ae.getSource()==phbtn) 
		{
            this.setVisible(false);
			Photoupload ph1=new Photoupload();
			ph1.setVisible(true);
        }
		if(ae.getSource()==vpbtn)
			{
				this.setVisible(false);
				Viewpost vp1=new Viewpost();
				vp1.setVisible(true);
			}
		}
	}
	
