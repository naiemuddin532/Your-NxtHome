package Frames;

import java.lang.*;
import javax.swing.*;
import java.awt.event.*;
import java.awt.*;
import java.io.*;
public class Adminpanel extends JFrame implements MouseListener,ActionListener
{
	JLabel admnlbl,usrinfo,admninfo,usrlbl,admnpnl,hdlbl;
	Color captionclr,btnclr;
	Font fnt1,fnt2;
	JButton cbtn;
	ImageIcon img;
	JPanel panel;
	public Adminpanel()
	{
		super("Your NxtHome");
		this.setSize(1326,744);
		this.setLocationRelativeTo(null);
		panel=new JPanel();
		panel.setLayout(null);
		
		fnt1= new Font("sref",Font.PLAIN,24);
		fnt2= new Font("Comic Sans MS",Font.BOLD,32);
		
		captionclr=new Color(0,3,100);
		btnclr=new Color(42,155,247);
		
		hdlbl=new JLabel("ADMIN PANEL");
		hdlbl.setBounds(320,370,350,50);
		hdlbl.setFont(fnt2);
		hdlbl.setForeground(Color.WHITE);
		hdlbl.addMouseListener(this);
		panel.add(hdlbl);
		
		admnlbl=new JLabel("Add New Admin");
		admnlbl.setBounds(1020,620,400,40);
		admnlbl.setFont(fnt2);
		admnlbl.setForeground(captionclr);
		admnlbl.addMouseListener(this);
		panel.add(admnlbl);
		
		usrinfo= new JLabel("User Info.");
		usrinfo.setBounds(1050,250,300,40);
		usrinfo.setBackground(Color.WHITE);
		usrinfo.setForeground(captionclr);
		usrinfo.setFont(fnt2);
		usrinfo.addMouseListener(this);
		panel.add(usrinfo);
		
		admninfo=new JLabel("Admin Info");
		admninfo.setBounds(700,250,300,40);
		admninfo.setFont(fnt2);
		admninfo.setForeground(captionclr);
		admninfo.addMouseListener(this);
		panel.add(admninfo);
		
		usrlbl= new JLabel("Add New User");
		usrlbl.setBounds(670,620,300,40);
		usrlbl.setBackground(Color.WHITE);
		usrlbl.setForeground(captionclr);
		usrlbl.setFont(fnt2);
		usrlbl.addMouseListener(this);
		panel.add(usrlbl);
		
		cbtn=new JButton("Sign Out");
		cbtn.setBounds(200,600,150,40);
		cbtn.setBackground(Color.RED);
		cbtn.setFont(fnt1);
		cbtn.addMouseListener(this);
		cbtn.addActionListener(this);
		panel.add(cbtn);
		
		img=new ImageIcon("Image/Adminpanel.PNG");
		admnpnl=new JLabel(img);
		admnpnl.setBounds(0,0,1326,744);
		panel.add(admnpnl);
		
		this.add(panel);
	}
	public void mouseClicked(MouseEvent me)
	{
		if(me.getSource()==admnlbl)
		{
			this.setVisible(false);
			Newadmin na1=new Newadmin();
			na1.setVisible(true);
		}
		else if(me.getSource()==usrlbl)
		{
			this.setVisible(false);
			Signupbyadmn su2=new Signupbyadmn();
			su2.setVisible(true);
		}
		else if(me.getSource()==admninfo)
		{
			JOptionPane.showMessageDialog(this, "This service is currently unavailable. We are working to fix it as soon as possible.");
		}
		else if(me.getSource()==usrinfo)
		{
			JOptionPane.showMessageDialog(this, "This service is currently unavailable. We are working to fix it as soon as possible.");
		}
	}
	public void mousePressed(MouseEvent me){}
	public void mouseReleased(MouseEvent me){}
	public void mouseEntered(MouseEvent me)
	{
		if(me.getSource()==cbtn)
		{
			cbtn.setForeground(Color.WHITE);
		} 
		else if(me.getSource()==admnlbl)
		{
			admnlbl.setForeground(Color.WHITE);
		}
		else if(me.getSource()==admninfo)
		{
			admninfo.setForeground(Color.WHITE);
		}
		else if(me.getSource()==usrinfo)
		{
			usrinfo.setForeground(Color.WHITE);
		}
		else if(me.getSource()==usrlbl)
		{
			usrlbl.setForeground(Color.WHITE);
		}
	}
	public void mouseExited(MouseEvent me)
	{
		if(me.getSource()==cbtn)
		{
			cbtn.setForeground(captionclr);
		}
		else if(me.getSource()==admnlbl)
		{
			admnlbl.setForeground(captionclr);
		}
		else if(me.getSource()==admninfo)
		{
			admninfo.setForeground(captionclr);
		}
		else if(me.getSource()==usrinfo)
		{
			usrinfo.setForeground(captionclr);
		}
		else if(me.getSource()==usrlbl)
		{
			usrlbl.setForeground(captionclr);
		}

	}
	public void actionPerformed(ActionEvent ae)
	{
		if(ae.getSource()==cbtn)
		{
			this.setVisible(false);
			MainFrame m1=new MainFrame();
			m1.setVisible(true);
		}
		
	}
	
}