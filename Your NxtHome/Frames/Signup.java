package Frames;

import java.lang.*;
import javax.swing.*;
import java.awt.event.*;
import java.awt.*;
import java.io.*;
public class Signup extends JFrame implements MouseListener,ActionListener
{
	JLabel hdlbl,nmlbl,nmbrlbl,nidlbl,adlbl,elbl,occlbl,cmntlbl1,cmntlbl2,cmntlbl3,usrlbl,passlbl,imglbl2;
	JTextField nmfld,nmbrfld,nidfld,adfld,efld,occfld,usrfld;
	JPasswordField passfld;
	JButton sbtn,bbtn;
	JCheckBox c1,c2;
	JComboBox combo;
	Color captionclr,btnclr;
	Font fnt1,fnt2,fnt3;
	ImageIcon img;
	JPanel panel;
	public Signup()
	{
		super("Your NxtHome");
		this.setSize(1326,744);
		this.setLocationRelativeTo(null);
		panel=new JPanel();
		panel.setLayout(null);
		
		fnt1= new Font("Comic Sans MS",Font.BOLD | Font.ITALIC,38);
		fnt2= new Font("Aptos Black",Font.BOLD,20);
		fnt3= new Font("Comic Sans MS",Font.BOLD,22);
		captionclr=new Color(0,2,61);
		btnclr=new Color(42,155,247);
		
		hdlbl=new JLabel("Almost there ! Just tell us a bit about you.");
		hdlbl.setBounds(250,50,1000,100);
		hdlbl.setFont(fnt1);
		hdlbl.setForeground(captionclr);
		panel.add(hdlbl);
		
		nmlbl=new JLabel("Full Name:");
		nmlbl.setBounds(15,100,150,30);
		nmlbl.setFont(fnt3);
		nmlbl.setForeground(captionclr);
		panel.add(nmlbl);
		
		nmfld= new JTextField();
		nmfld.setBounds(15,140,200,30);
		nmfld.setBackground(Color.WHITE);
		nmfld.setForeground(captionclr);
		nmfld.setFont(fnt3);
		panel.add(nmfld);
		
		nmbrlbl=new JLabel("Mobile Number:");
		nmbrlbl.setBounds(15,175,230,30);
		nmbrlbl.setFont(fnt3);
		nmbrlbl.setForeground(captionclr);
		panel.add(nmbrlbl);
		
		nmbrfld= new JTextField();
		nmbrfld.setBounds(15,210,200,30);
		nmbrfld.setBackground(Color.WHITE);
		nmbrfld.setForeground(captionclr);
		nmbrfld.setFont(fnt3);
		panel.add(nmbrfld);
		
		nidlbl=new JLabel("Nid Number:");
		nidlbl.setBounds(15,255,170,30);
		nidlbl.setFont(fnt3);
		nidlbl.setForeground(captionclr);
		panel.add(nidlbl);
		
		nidfld= new JTextField();
		nidfld.setBounds(15,300,200,30);
		nidfld.setBackground(Color.WHITE);
		nidfld.setForeground(captionclr);
		nidfld.setFont(fnt3);
		panel.add(nidfld);
		
		elbl=new JLabel("Valid E-mail:");
		elbl.setBounds(15,345,170,30);
		elbl.setFont(fnt3);
		elbl.setForeground(captionclr);
		panel.add(elbl);
		
		efld= new JTextField();
		efld.setBounds(15,390,200,30);
		efld.setBackground(Color.WHITE);
		efld.setForeground(captionclr);
		efld.setFont(fnt3);
		panel.add(efld);
		
		adlbl=new JLabel("Address:");
		adlbl.setBounds(15,435,170,30);
		adlbl.setFont(fnt3);
		adlbl.setForeground(captionclr);
		panel.add(adlbl);
		
		adfld= new JTextField();
		adfld.setBounds(15,480,200,30);
		adfld.setBackground(Color.WHITE);
		adfld.setForeground(captionclr);
		adfld.setFont(fnt3);
		panel.add(adfld);
		
		occlbl=new JLabel("Occupation:");
		occlbl.setBounds(15,525,170,30);
		occlbl.setFont(fnt3);
		occlbl.setForeground(captionclr);
		panel.add(occlbl);
		
		occfld= new JTextField();
		occfld.setBounds(15,570,200,30);
		occfld.setBackground(Color.WHITE);
		occfld.setForeground(captionclr);
		occfld.setFont(fnt3);
		panel.add(occfld);
		
		usrlbl=new JLabel("User ID:");
		usrlbl.setBounds(400,525,170,30);
		usrlbl.setFont(fnt3);
		usrlbl.setForeground(captionclr);
		panel.add(usrlbl);
		
		cmntlbl1=new JLabel("<html>#Save your user ID and password<br>for seamless future logins.</html>");
		cmntlbl1.setBounds(300,330,500,300);
		cmntlbl1.setFont(fnt3);
		cmntlbl1.setForeground(btnclr);
		panel.add(cmntlbl1);
		
		usrfld= new JTextField();
		usrfld.setBounds(400,570,200,30);
		usrfld.setBackground(Color.WHITE);
		usrfld.setForeground(captionclr);
		usrfld.setFont(fnt3);
		panel.add(usrfld);
		
		passlbl=new JLabel("Password:");
		passlbl.setBounds(400,615,200,30);
		passlbl.setFont(fnt3);
		passlbl.setForeground(captionclr);
		panel.add(passlbl);
		
		passfld= new JPasswordField();
		passfld.setBounds(400,650,200,30);
		passfld.setBackground(Color.WHITE);
		passfld.setForeground(captionclr);
		passfld.setFont(fnt3);
		passfld.setEchoChar('*');
		panel.add(passfld);
		
		sbtn=new JButton("SAVE");
		sbtn.setBounds(30,650,100,40);
		sbtn.setBackground(btnclr);
		sbtn.setFont(fnt3);
		sbtn.addMouseListener(this);
		sbtn.addActionListener(this);
		panel.add(sbtn);
		
		bbtn=new JButton("Back");
		bbtn.setBounds(150,650,100,40);
		bbtn.setBackground(Color.RED);
		bbtn.setFont(fnt3);
		bbtn.addMouseListener(this);
		bbtn.addActionListener(this);
		panel.add(bbtn);
		
		cmntlbl2=new JLabel("*Gender:");
		cmntlbl2.setBounds(350,170,100,30);
		cmntlbl2.setFont(fnt3);
		cmntlbl2.setForeground(captionclr);
		panel.add(cmntlbl2);
		
		cmntlbl3=new JLabel("*Are You a -");
		cmntlbl3.setBounds(350,300,200,40);
		cmntlbl3.setFont(fnt3);
		cmntlbl3.setForeground(captionclr);
		panel.add(cmntlbl3);
		
		c1=new JCheckBox("male");
		c1.setBounds(360,190,100,60);
		c1.setFont(fnt2);
		c1.setOpaque(false);
		panel.add(c1);
		
		c2=new JCheckBox("Female");
		c2.setBounds(360,230,100,60);
		c2.setFont(fnt2);
		c2.setOpaque(false);
		panel.add(c2);
		
		String items[] = {"HouseOwner","Tenant"};
		combo=new JComboBox(items);
		combo.setBounds(500,300,100,40);
		panel.add(combo);
		
		img=new ImageIcon("Image/signup.PNG");
		imglbl2=new JLabel(img);
		imglbl2.setBounds(0,0,1326,744);
		panel.add(imglbl2);
		
		
		
		
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
		String newusr=usrfld.getText().trim();
		String newpass=passfld.getText().trim();
		if(ae.getSource()==bbtn)
		{
			this.setVisible(false);
			MainFrame m1=new MainFrame();
			m1.setVisible(true);
		}
		if(ae.getSource()==sbtn)
		{
		if (nmfld.getText().trim().isEmpty() || nmbrfld.getText().trim().isEmpty() || nidfld.getText().trim().isEmpty() || efld.getText().trim().isEmpty() || occfld.getText().trim().isEmpty() || usrfld.getText().trim().isEmpty() || adfld.getText().trim().isEmpty())
			{
				JOptionPane.showMessageDialog(this, "Please Fill up the from correctly.");
				return;
			}
			else{
		try{
			File datafldr=new File("Data");
			if(!datafldr.exists())
			{
				datafldr.mkdir();
			}
			File usrfile=new File("Data/user_info.txt");
			if(!usrfile.exists())
			{
				usrfile.createNewFile();
			}
			
			BufferedWriter wtr=new BufferedWriter(new FileWriter(usrfile,true));
			wtr.write("User ID:" +newusr);
			wtr.newLine();
			wtr.write("Password:" +newpass);
			wtr.newLine();
			wtr.close();
		}
		catch(IOException ioe)
		{
			ioe.printStackTrace();
		}
				JOptionPane.showMessageDialog(this, "Thank you for trusting us and sharing your idntity.");
				this.setVisible(false);
				MainFrame m1=new MainFrame();
				m1.setVisible(true);
		}}

	}
}