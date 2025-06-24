package Frames;

import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.io.*;
import java.nio.file.*;
public class Photoupload extends JFrame implements MouseListener
{
	JLabel cap1,nopic1,imglbl,imglbl2;
	JButton sbtn,bbtn,upbtn;
	JTextField msg1;
	Font fnt1,fnt2;
	ImageIcon img;
	Color btnclr;
	JPanel panel;
	private File selectedFile = null;
	Photoupload()
	{
		super("Your NxtHome");
		this.setSize(1326,744);
		this.setLocationRelativeTo(null);
		panel=new JPanel();
		panel.setLayout(null);
		
		fnt1= new Font("sref",Font.PLAIN,24);
		fnt2= new Font("Comic Sans MS",Font.BOLD | Font.ITALIC,28);
		
		btnclr=new Color(42,155,247);
		
		cap1=new JLabel("Details:");
		cap1.setBounds(70,70,150,50);
		cap1.setFont(fnt2);
		panel.add(cap1);
		
		nopic1 = new JLabel("No Image Selected!");
		nopic1.setBounds(610,265,220,45);
		nopic1.setBackground(Color.WHITE);
		nopic1.setOpaque(true);
		nopic1.setFont(fnt1);
		nopic1.setForeground(Color.BLUE);
		panel.add(nopic1);
		
		msg1=new JTextField();
		msg1.setBounds(70,120,400,350);
		panel.add(msg1);
		
		upbtn=new JButton("Upload your Flat Photo");
		upbtn.setBounds(510,500,400,60);
		upbtn.setBackground(Color.GREEN);
		upbtn.setFont(fnt2);
		upbtn.addMouseListener(this);
		panel.add(upbtn);
		
		bbtn=new JButton("Back");
		bbtn.setBounds(750,600,100,40);
		bbtn.setBackground(Color.RED);
		bbtn.setFont(fnt2);
		bbtn.addMouseListener(this);
		//bbtn.addActionListener(this);
		panel.add(bbtn);
		
		sbtn=new JButton("Post");
		sbtn.setBounds(555,600,100,40);
		sbtn.setBackground(btnclr);
		sbtn.setFont(fnt2);
		sbtn.addMouseListener(this);
		panel.add(sbtn);
		
		imglbl2 = new JLabel();
        imglbl2.setBounds(570,130, 300, 300);
        imglbl2.setBackground(Color.LIGHT_GRAY);
        imglbl2.setOpaque(true);
        panel.add(imglbl2);
		
		
		img=new ImageIcon("Image/photoupload.PNG");
		imglbl=new JLabel(img);
		imglbl.setBounds(0,0,1326,744);
		panel.add(imglbl);
		this.add(panel);
		
	}
	
	public void mouseClicked(MouseEvent me)
	{
		if (me.getSource() == upbtn) {
            choosePhoto();
        } else if (me.getSource() == sbtn) {
            postPhoto();
        } 
		else if(me.getSource()==bbtn)
		{
			this.setVisible(false);
			Page4 p4=new Page4();
			p4.setVisible(true);
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
		else if(me.getSource()==upbtn)
		{
			upbtn.setForeground(Color.WHITE);
		}
		
	}
	public void mouseExited(MouseEvent me)
	{
		if(me.getSource()==sbtn)
		{
			sbtn.setForeground(Color.BLACK);
		}
		else if(me.getSource()==bbtn)
		{
			bbtn.setForeground(Color.BLACK);
		}
		
		else if(me.getSource()==upbtn)
		{
			upbtn.setForeground(Color.BLACK);
		}
	}
	
	private void choosePhoto() 
	{
        JFileChooser csr = new JFileChooser();
        int result = csr.showOpenDialog(this);
        if (result == JFileChooser.APPROVE_OPTION) {
            selectedFile = csr.getSelectedFile();
            ImageIcon icon = new ImageIcon(selectedFile.getAbsolutePath());
            Image scaled = icon.getImage().getScaledInstance(300, 300, Image.SCALE_DEFAULT);
			imglbl2.setIcon(new  ImageIcon(scaled));
            nopic1.setVisible(false);
        }
    }
	
	private void postPhoto() {
        if (selectedFile == null) {
            JOptionPane.showMessageDialog(this, "Please choose a photo.");
            return;
        }

        String message = msg1.getText().trim();

        try {
            File postsDir = new File("posts");
            if (postsDir.exists() == false) 
			{
				postsDir.mkdir();
			}
            File pstimg = new File(postsDir, selectedFile.getName());
            Files.copy(selectedFile.toPath(), pstimg.toPath(), StandardCopyOption.REPLACE_EXISTING);

            
			String msgFileName = selectedFile.getName().replaceAll("\\.[^.]+$", "") + "_msg.txt";
            File messageFile = new File(postsDir, msgFileName);
            try (BufferedWriter writer = new BufferedWriter(new FileWriter(messageFile))) {
                writer.write(message);
            }

            JOptionPane.showMessageDialog(this, "Congratulations!Your Post was Shared.");
            imglbl2.setIcon(null);
			msg1.setText("");
            nopic1.setText("No Image Selected!");

        } catch (IOException ex) {
            ex.printStackTrace(); 
            JOptionPane.showMessageDialog(this, "Failed to share your post .");
        }
    }
}