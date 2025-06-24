package Frames;

import java.lang.*;
import javax.swing.*;
import java.awt.event.*;
import java.awt.*;
public class Support extends JFrame implements MouseListener,ActionListener
{
	JLabel imglbl1;
	JButton fbtn,ibtn,wbtn,bbtn;
	Font fnt1;
	ImageIcon img,fimg,iimg,wimg;
	JPanel panel;
	public Support()
	{
		super("Your NxtHome");
		this.setSize(1326,746);
		this.setLocationRelativeTo(null);
		panel=new JPanel();
		panel.setLayout(null);
		
		fnt1= new Font("Comic Sans MS",Font.ITALIC,30);
		
		fimg=new ImageIcon("Image/fimg.PNG");
		Image fbimg=fimg.getImage().getScaledInstance(100,100,Image.SCALE_DEFAULT);
		fimg=new ImageIcon(fbimg);
		fbtn=new JButton(fimg);
		fbtn.setBounds(850,300,100,100);
		fbtn.setFont(fnt1);
		fbtn.addMouseListener(this);
		fbtn.addActionListener(this);
		panel.add(fbtn);
		
		wimg=new ImageIcon("Image/wimg.PNG");
		Image wpimg=wimg.getImage().getScaledInstance(100,100,Image.SCALE_DEFAULT);
		wimg=new ImageIcon(wpimg);
		wbtn=new JButton(wimg);
		wbtn.setBounds(970,300,100,100);
		wbtn.setBackground(Color.GREEN);
		wbtn.addMouseListener(this);
		wbtn.addActionListener(this);
		panel.add(wbtn);
		
		iimg=new ImageIcon("Image/iimg.PNG");
		Image igimg=iimg.getImage().getScaledInstance(100,100,Image.SCALE_DEFAULT);
		iimg=new ImageIcon(igimg);
		ibtn=new JButton(iimg);
		ibtn.setBounds(1100,300,100,100);
		ibtn.setFont(fnt1);
		ibtn.addMouseListener(this);
		ibtn.addActionListener(this);
		panel.add(ibtn);
		
		bbtn=new JButton("Back");
		bbtn.setBounds(950,450,120,40);
		bbtn.setBackground(Color.RED);
		bbtn.setFont(fnt1);
		bbtn.addMouseListener(this);
		bbtn.addActionListener(this);
		panel.add(bbtn);
		
		img=new ImageIcon("Image/Support.PNG");
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
		if(me.getSource()==fbtn)
		{
			fbtn.setForeground(Color.WHITE);
		}
		else if(me.getSource()==bbtn)
		{
			bbtn.setForeground(Color.WHITE);
		} 
		else if(me.getSource()==wbtn)
		{
			wbtn.setForeground(Color.WHITE);
		}
		else if(me.getSource()==ibtn)
		{
			ibtn.setForeground(Color.WHITE);
		}
		
	}
	public void mouseExited(MouseEvent me)
	{
		if(me.getSource()==fbtn)
		{
			fbtn.setForeground(Color.BLACK);
		}
		else if(me.getSource()==bbtn)
		{
			bbtn.setForeground(Color.BLACK);
		}
		
		else if(me.getSource()==wbtn)
		{
			wbtn.setForeground(Color.BLACK);
		}
		else if(me.getSource()==ibtn)
		{
			ibtn.setForeground(Color.WHITE);
		}
	}
	public void actionPerformed(ActionEvent ae)
	{
		if(ae.getSource()==fbtn)
		{
			JOptionPane.showMessageDialog(this, "We're sorry!This service is currently unavailable.We're working to fix the issue and will be back shortly. Thank you for your patience!.");
            return;
		}
		if(ae.getSource()==wbtn)
		{
			JOptionPane.showMessageDialog(this, "Oops! Service unavailable. We're fixing it — back soon!");
            return;
		}
		if(ae.getSource()==ibtn)
		{
			JOptionPane.showMessageDialog(this, "We're sorry!This service is currently unavailable.We're working to fix the issue and will be back shortly. Thank you for your patience!.");
            return;
		}
		if(ae.getSource()==bbtn)
		{
			this.setVisible(false);
			MainFrame m1=new MainFrame();
			m1.setVisible(true);
		}
	}
}