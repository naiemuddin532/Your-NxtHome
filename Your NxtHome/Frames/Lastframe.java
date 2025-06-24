package Frames;

import java.lang.*;
import javax.swing.*;
import java.awt.event.*;
import java.awt.*;
public class Lastframe extends JFrame implements MouseListener,ActionListener
{
	
	JLabel head1,mid1,mid2,mid3,imglbl1;
	JButton exitbtn;
	Color captionclr,brndnmclr;
	Font fnt1,fnt4;
	ImageIcon img;
	JPanel panel;
	public Lastframe()
	{
		super("Your NxtHome");
		this.setSize(1326,746);
		this.setLocationRelativeTo(null);
		panel=new JPanel();
		panel.setLayout(null);
		
		fnt1= new Font("Comic Sans MS",Font.BOLD | Font.ITALIC,40);
		fnt4= new Font("sref",Font.PLAIN,16);
		captionclr=new Color(0,3,100);
		brndnmclr=new Color(23,59,11);
		
		head1=new JLabel("Congratulations! Your Booking is Confirmed!");
		head1.setBounds(200,70,999,100);
		head1.setFont(fnt1);
		head1.setForeground(captionclr);
		panel.add(head1);
		
		mid1=new JLabel("<html>Your booking has been<br>successfully confirmed.<br>Our team will contact you soon.</html>");
		mid1.setBounds(280,200,500,500);
		mid1.setFont(fnt4);
		mid1.setForeground(captionclr);
		panel.add(mid1);
		
		mid2=new JLabel("<html>Thank you for choosing us.Your<br>trust means the world to us,and<br>we’re committed to providing you<br>with the best experience possible</html>");
		mid2.setBounds(550,200,500,500);
		mid2.setFont(fnt4);
		mid2.setForeground(captionclr);
		panel.add(mid2);
		
		mid3=new JLabel("<html>If you have any questions or<br>need assistance,<br>don’t hesitate to reach out.<br>We’re here for you!</html>");
		mid3.setBounds(830,200,500,500);
		mid3.setFont(fnt4);
		mid3.setForeground(captionclr);
		panel.add(mid3);
		
		exitbtn=new JButton("Exit");
		exitbtn.setBounds(550,544,150,60);
		exitbtn.setBackground(Color.RED);
		exitbtn.setFont(fnt1);
		exitbtn.addMouseListener(this);
		exitbtn.addActionListener(this);
		panel.add(exitbtn);
		
		
		
		img=new ImageIcon("Image/lp.PNG");
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
		if(me.getSource()==exitbtn)
		{
			exitbtn.setForeground(Color.WHITE);
		}
	}
	public void mouseExited(MouseEvent me)
	{
		if(me.getSource()==exitbtn)
		{
			exitbtn.setForeground(Color.BLACK);
		}
	}
	public void actionPerformed(ActionEvent ae)
	{
		if(ae.getSource()==exitbtn)
		{
			this.setVisible(false);
		}
	}
} 