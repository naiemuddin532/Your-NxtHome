\\

package Frames;

import java.lang.*;
import javax.swing.*;
import java.awt.event.*;
import java.awt.*;
import java.io.*;
public class Signin extends JFrame implements MouseListener,ActionListener
{
	JLabel usrlbl,passlbl,cap1,cap2,cap3,cap4,imglbl2,admnlbl,ulbl,admnimglbl;
	JTextField nmfld;
	JPasswordField passfld;
	JButton sbtn,bbtn,nbtn;
	//JCheckBox c1,c2;
	Color captionclr,brndnmclr,btnclr;
	Font fnt1,fnt2,fnt3,fnt4;
	ImageIcon img,aimg;
	JPanel panel;
	public Signin()
	{
		super("Your NxtHome");
		this.setSize(1326,744);
		this.setLocationRelativeTo(null);
		panel=new JPanel();
		panel.setLayout(null);
		
		fnt1= new Font("Comic Sans MS",Font.BOLD | Font.ITALIC,40);
		fnt2= new Font("Comic Sans MS",Font.BOLD,32);
		fnt3= new Font("Comic Sans MS",Font.BOLD,24);
		fnt4= new Font("sref",Font.PLAIN,24);
		captionclr=new Color(0,3,100);
		brndnmclr=new Color(23,59,11);
		btnclr=new Color(42,155,247);
		
		ulbl=new JLabel("User Log in");
		ulbl.setBounds(250,50,200,60);
		ulbl.setFont(fnt2);
		ulbl.setForeground(Color.BLUE);
		ulbl.addMouseListener(this);
		panel.add(ulbl);
		
		admnlbl=new JLabel("Admin Log in");
		admnlbl.setBounds(700,50,200,60);
		admnlbl.setFont(fnt2);
		admnlbl.setForeground(captionclr);
		admnlbl.addMouseListener(this);
		panel.add(admnlbl);
		
		usrlbl=new JLabel("User ID :");
		usrlbl.setBounds(50,250,200,40);
		usrlbl.setFont(fnt2);
		usrlbl.setForeground(captionclr);
		panel.add(usrlbl);
		
		nmfld= new JTextField();
		nmfld.setBounds(220,250,300,40);
		nmfld.setBackground(Color.WHITE);
		nmfld.setForeground(captionclr);
		nmfld.setFont(fnt4);
		panel.add(nmfld);
		
		passlbl=new JLabel("Password:");
		passlbl.setBounds(50,300,250,40);
		passlbl.setFont(fnt2);
		passlbl.setForeground(captionclr);
		panel.add(passlbl);
		
		passfld= new JPasswordField();
		passfld.setBounds(220,300,300,40);
		passfld.setBackground(Color.WHITE);
		passfld.setForeground(captionclr);
		passfld.setFont(fnt4);
		passfld.setEchoChar('*');
		panel.add(passfld);
		
		sbtn=new JButton("Sign IN");
		sbtn.setBounds(100,400,145,40);
		sbtn.setBackground(btnclr);
		sbtn.setFont(fnt4);
		sbtn.addMouseListener(this);
		sbtn.addActionListener(this);
		panel.add(sbtn);
		
		bbtn=new JButton("Back");
		bbtn.setBounds(400,400,100,40);
		bbtn.setBackground(Color.RED);
		bbtn.setFont(fnt4);
		bbtn.addMouseListener(this);
		bbtn.addActionListener(this);
		panel.add(bbtn);
		
		nbtn=new JButton("New Account");
		nbtn.setBounds(220,630,200,40);
		nbtn.setBackground(Color.GREEN);
		nbtn.setFont(fnt4);
		nbtn.addActionListener(this);
		nbtn.addMouseListener(this);
		panel.add(nbtn);
		
		cap1=new JLabel("Don’t have an account?");
		cap1.setBounds(50,480,480,50);
		cap1.setFont(fnt1);
		cap1.setForeground(captionclr);
		panel.add(cap1);
		
		cap2=new JLabel("No worries!");
		cap2.setBounds(150,530,300,100);
		cap2.setFont(fnt1);
		cap2.setForeground(brndnmclr);
		panel.add(cap2);
		
		cap3=new JLabel("You can Create");
		cap3.setBounds(30,600,480,100);
		cap3.setFont(fnt3);
		cap3.setForeground(captionclr);
		panel.add(cap3);
		
		cap4=new JLabel("for free right here!");
		cap4.setBounds(430,600,480,100);
		cap4.setFont(fnt3);
		cap4.setForeground(captionclr);
		panel.add(cap4);
		
		img=new ImageIcon("Image/user.PNG");
		imglbl2=new JLabel(img);
		imglbl2.setBounds(0,0,1326,744);
		panel.add(imglbl2);
	
		this.add(panel);
	}
	public void mouseClicked(MouseEvent me)
	{
		if(me.getSource()==ulbl)
		{
			admnlbl.setVisible(false);
		}
		else if(me.getSource()==admnlbl)
		{
			this.setVisible(false);
			Admin a1=new Admin();
			a1.setVisible(true);
		}
	}
	public void mousePressed(MouseEvent me){}
	public void mouseReleased(MouseEvent me){}
	public void mouseEntered(MouseEvent me)
	{
		if(me.getSource()==sbtn)
		{
			sbtn.setForeground(Color.WHITE);
		}
		else if(me.getSource()==bbtn)
		{
			bbtn.setForeground(Color.WHITE);
		} 
		else if(me.getSource()==nbtn)
		{
			nbtn.setForeground(Color.WHITE);
		}
		else if(me.getSource()==ulbl)
		{
			ulbl.setForeground(captionclr);
		}
		else if(me.getSource()==admnlbl)
		{
			admnlbl.setForeground(Color.WHITE);
		}
		
	}
	public void mouseExited(MouseEvent me)
	{
		if(me.getSource()==sbtn)
		{
			sbtn.setForeground(captionclr);
		}
		else if(me.getSource()==bbtn)
		{
			bbtn.setForeground(captionclr);
		}
		
		else if(me.getSource()==nbtn)
		{
			nbtn.setForeground(captionclr);
		}
		else if(me.getSource()==admnlbl)
		{
			admnlbl.setForeground(captionclr);
		}
		else if(me.getSource()==ulbl)
		{
			ulbl.setForeground(Color.BLUE);
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
		if(ae.getSource()==nbtn)
		{
			this.setVisible(false);
			Signup su1=new Signup();
			su1.setVisible(true);
		}
		String usr=nmfld.getText().trim();
		String pass=passfld.getText().trim();
		if(ae.getSource()==sbtn)
		{
			if(usr.isEmpty() || pass.isEmpty())
			{
				JOptionPane.showMessageDialog(this,"Please fill up all fields.");
			}
				boolean found=false;
				try
				{
					BufferedReader rdr = new BufferedReader(new FileReader("Data/user_info.txt"));
					String line;
					while ((line = rdr.readLine()) != null)
					{
						if (line.equals("User ID:" +usr))
						{
						String nextLine = rdr.readLine();
						if (nextLine != null && nextLine.equals("Password:" +pass))
						{
                        found = true;
                        break;
						}
						}
						//rdr.close();
						
				}}
				catch(IOException ioe)
				{
					ioe.printStackTrace();
				}
			if(found)
						{
							JOptionPane.showMessageDialog(this, "Login Successful!");
							this.setVisible(false);
							Page4 p4=new Page4();
							p4.setVisible(true);
							
						}
						else {
								JOptionPane.showMessageDialog(this, "Wrong User ID or Password!");
							 }
					
		}
	}
}