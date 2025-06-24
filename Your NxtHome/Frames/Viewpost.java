package Frames;

import java.lang.*;
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.io.*;
public class Viewpost extends JFrame implements MouseListener,ActionListener
{
	JLabel imglbl1,iconlbl,pstlbl1,msglbl1,bg,caplbl;
	JScrollPane srlpnl1;
	ImageIcon img,icon;
	JButton cbtn,bbtn,exitbtn;
	Font fnt1,fnt2;
	Color btnclr;
	JPanel pstpnl1,pstbx,txtpnl;
	JTextField pstfld;
	public Viewpost()
	{
		super("Your NxtHome");
		this.setSize(1326,744);
		this.setLocationRelativeTo(null);
		
		fnt1= new Font("sref",Font.PLAIN,24);
		fnt2= new Font("Comic Sans MS",Font.ITALIC,30);
		btnclr=new Color(42,155,247);
		
		img=new ImageIcon("Image/page4b.PNG");
		bg=new JLabel(img);
		bg.setBounds(0,0,1326,744);
		this.setContentPane(bg);
		bg.setLayout(null);
		
		txtpnl=new JPanel(null);
		txtpnl.setOpaque(false);
		txtpnl.setBounds(800,100,350,50);
		
		caplbl=new JLabel("Please enter post number for confirmation.");
		caplbl.setBounds(780,25,500,80);
		caplbl.setForeground(Color.BLACK);
		caplbl.setFont(fnt1);
		bg.add(caplbl);
		
		pstfld= new JTextField();
		pstfld.setBounds(0,00,350,50);
		pstfld.setBackground(Color.WHITE);
		pstfld.setForeground(Color.BLACK);
		txtpnl.add(pstfld);
		
		bg.add(txtpnl);
		
		bbtn=new JButton("Back");
		bbtn.setBounds(1020,170,120,40);
		bbtn.setBackground(Color.RED);
		bbtn.setFont(fnt2);
		bbtn.addMouseListener(this);
		bbtn.addActionListener(this);
		bg.add(bbtn);
		
		cbtn=new JButton("Confirm");
		cbtn.setBounds(800,170,170,40);
		cbtn.setBackground(btnclr);
		cbtn.setFont(fnt2);
		cbtn.addMouseListener(this);
		cbtn.addActionListener(this);
		bg.add(cbtn);
		
		exitbtn=new JButton("Exit");
		exitbtn.setBounds(700,650,150,50);
		exitbtn.setBounds(700,650,150,50);
		exitbtn.setBackground(Color.RED);
		exitbtn.setFont(fnt2);
		exitbtn.addMouseListener(this);
		exitbtn.addActionListener(this);
		bg.add(exitbtn);
		
		pstpnl1=new JPanel();
		pstpnl1.setLayout(new BoxLayout(pstpnl1,BoxLayout.Y_AXIS));
		pstpnl1.setOpaque(false);
		
		srlpnl1=new JScrollPane(pstpnl1);
		srlpnl1.setBounds(50,250,1200,400);
		srlpnl1.setOpaque(false);
		srlpnl1.getViewport().setOpaque(false);
		
		bg.add(srlpnl1);
		
		
		loadpost();
		setVisible(true);
		

	}	
		public void loadpost()
		{
			File postsDir=new File("posts");
			
			if(!postsDir.exists())
			{
				JOptionPane.showMessageDialog(this,"Folder couldn't found.");
				return;
			}
			if(!postsDir.isDirectory())
			{
				JOptionPane.showMessageDialog(this,"'posts is not a folder'");
				return;
			}
			
			File[] allFiles=postsDir.listFiles();
			
			if(allFiles == null || allFiles.length == 0)
			{
				JOptionPane.showMessageDialog(this,"Folder is Empty.");
				return;
			}
			int count=1;
			for (File file:allFiles)
			{
				String name=file.getName().toLowerCase();
				if(name.endsWith(".jpg") || name.endsWith(".png") || name.endsWith(".jpeg"))
				{
					File imgFile=file;
					String fileName=name.substring(0,name.lastIndexOf('.'));
					File txtFile=new File("posts",fileName+"_msg.txt");
					
					StringBuilder msg=new StringBuilder();
					if(txtFile.exists())
					{
						try(BufferedReader rdr=new BufferedReader(new FileReader(txtFile)))
							{
								String line;
								while ((line=rdr.readLine()) !=null)
								{
									msg.append(line).append("\n");
								}
							}
						catch(IOException e)
							{
								e.printStackTrace();
							}
						
					}
					else
					{
						msg.append("NO message available.");
					}
					
					pstlbl1=new JLabel("Post No:"+count);
					pstlbl1.setAlignmentX(Component.LEFT_ALIGNMENT);
					
					icon=new ImageIcon(imgFile.getAbsolutePath());
					Image scaledImage =icon.getImage().getScaledInstance(300,200,Image.SCALE_DEFAULT);
					
					imglbl1=new JLabel(new ImageIcon(scaledImage));
					
					msglbl1=new JLabel("<html><div style='width:300px'>" +msg.toString().replace("\n", "<br>") +"</div></html>");
					
					pstbx=new JPanel();
					pstbx.setLayout(new BoxLayout(pstbx,BoxLayout.Y_AXIS));
					pstbx.setMaximumSize(new Dimension(500, 350));
					pstbx.setAlignmentX(Component.LEFT_ALIGNMENT);
					pstbx.setBackground(Color.WHITE);
					pstbx.add(Box.createVerticalStrut(10));
					pstbx.add(pstlbl1);
					pstbx.add(Box.createVerticalStrut(5));
					pstbx.add(imglbl1);
					pstbx.add(Box.createVerticalStrut(5));
					pstbx.add(msglbl1);
					pstbx.add(Box.createVerticalStrut(5));
					
					pstpnl1.add(pstbx);
					pstpnl1.add(Box.createVerticalStrut(10));
					
					count++;
				}
			}
			pstpnl1.revalidate();
			pstpnl1.repaint();
		}
		
	public void mouseClicked(MouseEvent me){}
	public void mousePressed(MouseEvent me){}
	public void mouseReleased(MouseEvent me){}
	public void mouseEntered(MouseEvent me)
	{
		if(me.getSource()==cbtn)
		{
			cbtn.setForeground(Color.WHITE);
		}
		else if(me.getSource()==bbtn)
		{
			bbtn.setForeground(Color.WHITE);
		} 
		else if(me.getSource()==exitbtn)
		{
			exitbtn.setForeground(Color.WHITE);
		}
		
	}
	public void mouseExited(MouseEvent me)
	{
		if(me.getSource()==cbtn)
		{
			cbtn.setForeground(Color.BLACK);
		}
		else if(me.getSource()==bbtn)
		{
			bbtn.setForeground(Color.BLACK);
		}
		
		else if(me.getSource()==exitbtn)
		{
			exitbtn.setForeground(Color.BLACK);
		}
	}
	public void actionPerformed(ActionEvent ae)
	{
		if(ae.getSource()==bbtn)
		{
			this.setVisible(false);
			Photoupload p1=new Photoupload();
			p1.setVisible(true);
		}
		if(ae.getSource()==cbtn)
		{
		if (pstfld.getText().trim().isEmpty()) {
            JOptionPane.showMessageDialog(this, "Please enter post number.");
            return;
        }
		else{this.setVisible(false);
			Lastframe l1=new Lastframe();
			l1.setVisible(true);
		}}
		if(ae.getSource()==exitbtn)
		{
			this.setVisible(false);
		}
	}
	
}