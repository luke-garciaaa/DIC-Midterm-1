using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace DIC_Actual_Midterm_1
{
    public partial class Form1 : Form
    {
        List<Panel> panels = new List<Panel>(); // 4/12/21 LG Initialize List for Panels

        List<Product> productinfo = new List<Product>();  // 4/12/21 LG Initialize List for products

        List<Order> orderinfo = new List<Order>(); // 4/12/21 LG Initialize List for orders

        public static string orderpath = @"orders.txt";  // 4/12/21 LG initialize paths for text files for orders and products
        public static string productspath = @"products.txt";
         // 4/12/24 LG initialize fileinfos and streams for products and orders
        public static FileInfo fiProducts;
        public static FileInfo fiOrders;
        Stream productstream;
        Stream orderstream;
        // 4/12/21 LG initialize formatter
        IFormatter formatter = new BinaryFormatter();
        public Form1()
        {
            InitializeComponent();
        }
        // 4/12/21 LG brings panels to front for ADD products and calls refreshproductform function
        private void button2_Click(object sender, EventArgs e) //BUTTON ADD PRODUCT
        {
            panels[1].BringToFront();
            totalrefresh();
        }
        // 4/12/21 LG refreshes form and brings correct panel to front
        private void buttonaddorder_Click(object sender, EventArgs e)
        {
            totalrefresh();
            panels[2].BringToFront();
           
        }
        // 4/12/21 LG declares filestream and fileinfo, and deserializes the form whenever it is opened
        private void Form1_Load(object sender, EventArgs e)
        {
            fiProducts = new FileInfo(productspath);
            productstream = new FileStream(productspath, FileMode.OpenOrCreate, FileAccess.Read);
         if(new FileInfo(productspath).Length != 0)  //deserializes data
            {
                productinfo = (List <Product>) formatter.Deserialize(productstream);
            }
            fiOrders = new FileInfo(orderpath);
            orderstream = new FileStream(orderpath, FileMode.OpenOrCreate, FileAccess.Read);
            if(new FileInfo(orderpath).Length != 0)
            {
                orderinfo = (List<Order>)formatter.Deserialize(orderstream);
            }

           
            // 4/12/21 LG Adding Panels and bringing panels to front 
            panels.Add(panelwelcome);
            panels.Add(paneladdproduct);
            panels.Add(paneladdorder);
            panels.Add(paneltransaction);

            gotoMenu(); //function that brings menu to front
            // closes
            productstream.Close();
            orderstream.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelID_Click(object sender, EventArgs e)
        {

        }

        private void textboxname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) //TEXTBOX PRICE
        {

        }

        private void textboxdescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonsubmit_Click(object sender, EventArgs e) // submit button for Add Product
        {
           
           
            Product sampleproduct = new Product(); // // 4/12/21 LG creates object for product class
            // 4/12/21 LG gives object correct properties and adds object to list to be accessed later.
            sampleproduct.ProductID = Int32.Parse(labelID.Text); 
            sampleproduct.Name = textboxproductname.Text;
            sampleproduct.Price = textboxproductprice.Text;
            sampleproduct.Description = textboxproductdescription.Text;

            productinfo.Add(sampleproduct);
            comboboxorder.Items.Add(sampleproduct.Name);
            totalrefresh();


        }

        private void buttonMainMenu_Click(object sender, EventArgs e) // for Add Product
        {
            gotoMenu(); // goes to menu
        }
        private void gotoMenu() // 4/12/21 LG function that makes form go to menu
        {
            panels[0].BringToFront();
        }
        private void refreshproductform()  // 4/12/21 LG two functions that were replaced by totalrefresh function, from a previous version 
            // of the program
        {
            labelID.Text = (productinfo.Count() + 1).ToString();
            textboxproductname.Text = "";
            textboxproductprice.Text = "";
            textboxproductdescription.Text = "";
        }
        private void refreshorderform()
        {
            labelorderID.Text = (orderinfo.Count() + 1).ToString();
            labelorderprice.Text = "";
            textboxcustomername.Text = "";
            comboboxorder.Text = "";
            
        }
        private void totalrefresh() // 4/12/21 LG refresh cuntion that combines two previous function, used to 
                                    //refresh the form after information is entered, and also is responsible for
                                    //displaying the correct product and order ID's automatically
                                    // this function also clears all entered data, so the form is ready to recieve information
        {
            labelID.Text = (productinfo.Count() + 1).ToString();
            textboxproductname.Text = "";
            textboxproductprice.Text = "";
            textboxproductdescription.Text = "";

            comboboxorder.Items.Clear();
           // foreach loop that adds objects to drop down box for selection
            foreach (Product product in productinfo)
            {
                comboboxorder.Items.Add(product.Name);
            }
            // 4/12/21 LG similar functionality as products, but for the addorder page.
            labelorderID.Text = (orderinfo.Count() + 1).ToString();
            labelorderprice.Text = "";
            textboxcustomername.Text = "";
            comboboxorder.Text = "";

            labeltransactions.Text = "";
            // 4/12/21 LG foreach loop that adds orders to the transaction page.
            foreach (Order order in orderinfo)
            {
                labeltransactions.Text += order.OrderID + " - " + order.Customername + " bought a pizza! \n";  
            }



        }
        // 4/12/21 LG Function that serializes the form whenever it is closed.
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

            productstream = new FileStream(productspath, FileMode.Open, FileAccess.Write);
            orderstream = new FileStream(orderpath, FileMode.Open, FileAccess.Write);

            formatter.Serialize(productstream, productinfo);
            formatter.Serialize(orderstream, orderinfo);

            productstream.Close();
            orderstream.Close();
        }
        // 4/12/21 LG Button that is responsible for saving new order.
        private void buttonsaveneworder_Click(object sender, EventArgs e)
        {
            Order sampleorder = new Order(); //creates new object of the order class and assigns it the correct properties
            sampleorder.OrderID = Int32.Parse(labelorderID.Text);
            sampleorder.Customername = textboxcustomername.Text;

            orderinfo.Add(sampleorder);  //adds object to list
            AddAlert(); //add alert function wasn't really neccessary, but I thought it would be used more often
            totalrefresh();

        }

        private void buttonordersubmit_Click(object sender, EventArgs e)
        {

        }

        private void buttonordermainmenu_Click(object sender, EventArgs e)
        {
            gotoMenu();
        }

        private void buttontransactionmenu_Click(object sender, EventArgs e)
        {
            gotoMenu();
        }

        private void buttontransaction_Click(object sender, EventArgs e) // 4/12/21 LG brings up the transaction page
        {
            panels[3].BringToFront();
        }

        private void comboboxorder_SelectedIndexChanged(object sender, EventArgs e)// 4/12/21 LG automatically adds price whenever
            // the pizza option is chosen from drop down menu
        {
            foreach(Product product in productinfo)
            {
                if (product.Name == comboboxorder.SelectedItem)
                {
                    labelorderprice.Text = product.Price;
                }
            }
        }
        private void AddAlert() // 4/12/21 LG add alert function that gives an alert whenever a pizza is successfully ordered
        {
            MessageBox.Show($"{textboxcustomername.Text} has ordered a {comboboxorder.SelectedItem} pizza for ${labelorderprice.Text}.");
        }
    }
}
