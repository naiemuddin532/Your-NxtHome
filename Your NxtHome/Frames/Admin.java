package Frames;

import java.lang.*;
import javax.swing.*;
import java.awt.event.*;
import java.awt.*;
import java.io.*;
public class Admin extends JFrame implements MouseListener,ActionListener
{
	JLabel usrlbl,passlbl,admnimglbl;
	JTextField nmfld;
	JPasswordField passfld;
	Color captionclr,btnclr;
	Font fnt1,fnt2;
	JButton sbtn,bbtn;
	ImageIcon img;
	JPanel panel;
	public Admin()
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
		
		usrlbl=new JLabel("Admin ID :");
		usrlbl.setBounds(700,300,200,40);
		usrlbl.setFont(fnt2);
		usrlbl.setForeground(captionclr);
		panel.add(usrlbl);
		
		nmfld= new JTextField();
		nmfld.setBounds(890,300,300,40);
		nmfld.setBackground(Color.WHITE);
		nmfld.setForeground(captionclr);
		nmfld.setFont(fnt1);
		panel.add(nmfld);
		
		passlbl=new JLabel("Password  :");
		passlbl.setBounds(695,350,250,40);
		passlbl.setFont(fnt2);
		passlbl.setForeground(captionclr);
		panel.add(passlbl);
		
		passfld= new JPasswordField();
		passfld.setBounds(890,350,300,40);
		passfld.setBackground(Color.WHITE);
		passfld.setForeground(captionclr);
		passfld.setFont(fnt1);
		passfld.setEchoChar('*');
		panel.add(passfld);
		
		sbtn=new JButton("Sign IN");
		sbtn.setBounds(850,450,145,40);
		sbtn.setBackground(btnclr);
		sbtn.setFont(fnt1);
		sbtn.addMouseListener(this);
		sbtn.addActionListener(this);
		panel.add(sbtn);
		
		bbtn=new JButton("Back");
		bbtn.setBounds(1050,450,100,40);
		bbtn.setBackground(Color.RED);
		bbtn.setFont(fnt1);
		bbtn.addMouseListener(this);
		bbtn.addActionListener(this);
		panel.add(bbtn);
		
		img=new ImageIcon("Image/admin.PNG");
		admnimglbl=new JLabel(img);
		admnimglbl.setBounds(0,0,1326,744);
		panel.add(admnimglbl);
		
		this.add(panel);

	}
	public void mouseClicked(MouseEvent me){}
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

	}
	public void actionPerformed(ActionEvent ae)
	{
		if(ae.getSource()==bbtn)
		{
			this.setVisible(false);
			MainFrame m1=new MainFrame();
			m1.setVisible(true);
		}
		String admn=nmfld.getText().trim();
		String pass=passfld.getText().trim();
		if(ae.getSource()==sbtn)
		{
			if(admn.isEmpty() || pass.isEmpty())
			{
				JOptionPane.showMessageDialog(this,"Please fill up all fields.");
			}
				boolean found=false;
				try
				{
					BufferedReader rdr = new BufferedReader(new FileReader("Data/admin_info.txt"));
					String line;
					while ((line = rdr.readLine()) != null)
					{
						if (line.equals("Admin ID:" +admn))
						{
						String nextLine = rdr.readLine();
						if (nextLine != null && nextLine.equals("Password:" +pass))
						{
                        found = true;
                        break;
						}
						}
				}}
				catch(IOException ioe)
				{
					ioe.printStackTrace();
				}
			if(found)
						{
							JOptionPane.showMessageDialog(this, "Authorized Login Successful!");
							this.setVisible(false);
							Adminpanel ap1=new Adminpanel();
							ap1.setVisible(true);
							
						}
						else {
								JOptionPane.showMessageDialog(this, "unauthorized ID or Password!");
							 }
					
		}
	}
}
