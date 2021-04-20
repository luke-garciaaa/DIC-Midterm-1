
namespace DIC_Actual_Midterm_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonaddorder = new System.Windows.Forms.Button();
            this.buttonaddproduct = new System.Windows.Forms.Button();
            this.buttontransaction = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelwelcome = new System.Windows.Forms.Panel();
            this.paneladdproduct = new System.Windows.Forms.Panel();
            this.buttonMainMenu = new System.Windows.Forms.Button();
            this.buttonsubmitproduct = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textboxproductdescription = new System.Windows.Forms.TextBox();
            this.textboxproductprice = new System.Windows.Forms.TextBox();
            this.textboxproductname = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.paneladdorder = new System.Windows.Forms.Panel();
            this.buttonsaveneworder = new System.Windows.Forms.Button();
            this.buttonordermainmenu = new System.Windows.Forms.Button();
            this.textboxcustomername = new System.Windows.Forms.TextBox();
            this.labelorderprice = new System.Windows.Forms.Label();
            this.labelorderID = new System.Windows.Forms.Label();
            this.comboboxorder = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.paneltransaction = new System.Windows.Forms.Panel();
            this.buttontransactionmenu = new System.Windows.Forms.Button();
            this.labeltransactions = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panelwelcome.SuspendLayout();
            this.paneladdproduct.SuspendLayout();
            this.paneladdorder.SuspendLayout();
            this.paneltransaction.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonaddorder
            // 
            this.buttonaddorder.Location = new System.Drawing.Point(277, 186);
            this.buttonaddorder.Name = "buttonaddorder";
            this.buttonaddorder.Size = new System.Drawing.Size(169, 47);
            this.buttonaddorder.TabIndex = 0;
            this.buttonaddorder.Text = "ADD ORDER";
            this.buttonaddorder.UseVisualStyleBackColor = true;
            this.buttonaddorder.Click += new System.EventHandler(this.buttonaddorder_Click);
            // 
            // buttonaddproduct
            // 
            this.buttonaddproduct.Location = new System.Drawing.Point(277, 107);
            this.buttonaddproduct.Name = "buttonaddproduct";
            this.buttonaddproduct.Size = new System.Drawing.Size(169, 47);
            this.buttonaddproduct.TabIndex = 1;
            this.buttonaddproduct.Text = "ADD PRODUCT";
            this.buttonaddproduct.UseVisualStyleBackColor = true;
            this.buttonaddproduct.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttontransaction
            // 
            this.buttontransaction.Location = new System.Drawing.Point(277, 271);
            this.buttontransaction.Name = "buttontransaction";
            this.buttontransaction.Size = new System.Drawing.Size(169, 47);
            this.buttontransaction.TabIndex = 2;
            this.buttontransaction.Text = "TRANSACTION";
            this.buttontransaction.UseVisualStyleBackColor = true;
            this.buttontransaction.Click += new System.EventHandler(this.buttontransaction_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Warehouse Pizza";
            // 
            // panelwelcome
            // 
            this.panelwelcome.Controls.Add(this.label1);
            this.panelwelcome.Controls.Add(this.buttontransaction);
            this.panelwelcome.Controls.Add(this.buttonaddproduct);
            this.panelwelcome.Controls.Add(this.buttonaddorder);
            this.panelwelcome.Location = new System.Drawing.Point(3, 3);
            this.panelwelcome.Name = "panelwelcome";
            this.panelwelcome.Size = new System.Drawing.Size(796, 478);
            this.panelwelcome.TabIndex = 4;
            // 
            // paneladdproduct
            // 
            this.paneladdproduct.Controls.Add(this.buttonMainMenu);
            this.paneladdproduct.Controls.Add(this.buttonsubmitproduct);
            this.paneladdproduct.Controls.Add(this.label6);
            this.paneladdproduct.Controls.Add(this.textboxproductdescription);
            this.paneladdproduct.Controls.Add(this.textboxproductprice);
            this.paneladdproduct.Controls.Add(this.textboxproductname);
            this.paneladdproduct.Controls.Add(this.labelID);
            this.paneladdproduct.Controls.Add(this.label5);
            this.paneladdproduct.Controls.Add(this.label3);
            this.paneladdproduct.Controls.Add(this.label2);
            this.paneladdproduct.Controls.Add(this.label4);
            this.paneladdproduct.Location = new System.Drawing.Point(0, 0);
            this.paneladdproduct.Name = "paneladdproduct";
            this.paneladdproduct.Size = new System.Drawing.Size(796, 488);
            this.paneladdproduct.TabIndex = 5;
            this.paneladdproduct.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // buttonMainMenu
            // 
            this.buttonMainMenu.Location = new System.Drawing.Point(411, 332);
            this.buttonMainMenu.Name = "buttonMainMenu";
            this.buttonMainMenu.Size = new System.Drawing.Size(146, 37);
            this.buttonMainMenu.TabIndex = 23;
            this.buttonMainMenu.Text = "MAIN MENU";
            this.buttonMainMenu.UseVisualStyleBackColor = true;
            this.buttonMainMenu.Click += new System.EventHandler(this.buttonMainMenu_Click);
            // 
            // buttonsubmitproduct
            // 
            this.buttonsubmitproduct.Location = new System.Drawing.Point(165, 332);
            this.buttonsubmitproduct.Name = "buttonsubmitproduct";
            this.buttonsubmitproduct.Size = new System.Drawing.Size(146, 37);
            this.buttonsubmitproduct.TabIndex = 22;
            this.buttonsubmitproduct.Text = "SUBMIT";
            this.buttonsubmitproduct.UseVisualStyleBackColor = true;
            this.buttonsubmitproduct.Click += new System.EventHandler(this.buttonsubmit_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(275, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 38);
            this.label6.TabIndex = 21;
            this.label6.Text = "ADD PRODUCT";
            // 
            // textboxproductdescription
            // 
            this.textboxproductdescription.Location = new System.Drawing.Point(261, 249);
            this.textboxproductdescription.Name = "textboxproductdescription";
            this.textboxproductdescription.Size = new System.Drawing.Size(242, 22);
            this.textboxproductdescription.TabIndex = 20;
            this.textboxproductdescription.TextChanged += new System.EventHandler(this.textboxdescription_TextChanged);
            // 
            // textboxproductprice
            // 
            this.textboxproductprice.Location = new System.Drawing.Point(261, 196);
            this.textboxproductprice.Name = "textboxproductprice";
            this.textboxproductprice.Size = new System.Drawing.Size(242, 22);
            this.textboxproductprice.TabIndex = 19;
            this.textboxproductprice.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textboxproductname
            // 
            this.textboxproductname.Location = new System.Drawing.Point(261, 147);
            this.textboxproductname.Name = "textboxproductname";
            this.textboxproductname.Size = new System.Drawing.Size(242, 22);
            this.textboxproductname.TabIndex = 18;
            this.textboxproductname.TextChanged += new System.EventHandler(this.textboxname_TextChanged);
            // 
            // labelID
            // 
            this.labelID.BackColor = System.Drawing.Color.White;
            this.labelID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelID.Location = new System.Drawing.Point(261, 91);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(242, 25);
            this.labelID.TabIndex = 17;
            this.labelID.Click += new System.EventHandler(this.labelID_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(102, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 38);
            this.label5.TabIndex = 16;
            this.label5.Text = "Name:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 38);
            this.label3.TabIndex = 15;
            this.label3.Text = "Price:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 38);
            this.label2.TabIndex = 14;
            this.label2.Text = "Description:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 38);
            this.label4.TabIndex = 13;
            this.label4.Text = "ID:";
            // 
            // paneladdorder
            // 
            this.paneladdorder.Controls.Add(this.buttonsaveneworder);
            this.paneladdorder.Controls.Add(this.buttonordermainmenu);
            this.paneladdorder.Controls.Add(this.textboxcustomername);
            this.paneladdorder.Controls.Add(this.labelorderprice);
            this.paneladdorder.Controls.Add(this.labelorderID);
            this.paneladdorder.Controls.Add(this.comboboxorder);
            this.paneladdorder.Controls.Add(this.label11);
            this.paneladdorder.Controls.Add(this.label10);
            this.paneladdorder.Controls.Add(this.label9);
            this.paneladdorder.Controls.Add(this.label8);
            this.paneladdorder.Controls.Add(this.label7);
            this.paneladdorder.Location = new System.Drawing.Point(0, 0);
            this.paneladdorder.Name = "paneladdorder";
            this.paneladdorder.Size = new System.Drawing.Size(799, 463);
            this.paneladdorder.TabIndex = 6;
            // 
            // buttonsaveneworder
            // 
            this.buttonsaveneworder.Location = new System.Drawing.Point(85, 350);
            this.buttonsaveneworder.Name = "buttonsaveneworder";
            this.buttonsaveneworder.Size = new System.Drawing.Size(164, 50);
            this.buttonsaveneworder.TabIndex = 33;
            this.buttonsaveneworder.Text = "SAVE NEW ORDER";
            this.buttonsaveneworder.UseVisualStyleBackColor = true;
            this.buttonsaveneworder.Click += new System.EventHandler(this.buttonsaveneworder_Click);
            // 
            // buttonordermainmenu
            // 
            this.buttonordermainmenu.Location = new System.Drawing.Point(518, 350);
            this.buttonordermainmenu.Name = "buttonordermainmenu";
            this.buttonordermainmenu.Size = new System.Drawing.Size(164, 50);
            this.buttonordermainmenu.TabIndex = 32;
            this.buttonordermainmenu.Text = "MAIN MENU";
            this.buttonordermainmenu.UseVisualStyleBackColor = true;
            this.buttonordermainmenu.Click += new System.EventHandler(this.buttonordermainmenu_Click);
            // 
            // textboxcustomername
            // 
            this.textboxcustomername.Location = new System.Drawing.Point(258, 294);
            this.textboxcustomername.Name = "textboxcustomername";
            this.textboxcustomername.Size = new System.Drawing.Size(241, 22);
            this.textboxcustomername.TabIndex = 30;
            // 
            // labelorderprice
            // 
            this.labelorderprice.BackColor = System.Drawing.Color.White;
            this.labelorderprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelorderprice.Location = new System.Drawing.Point(258, 233);
            this.labelorderprice.Name = "labelorderprice";
            this.labelorderprice.Size = new System.Drawing.Size(242, 25);
            this.labelorderprice.TabIndex = 29;
            // 
            // labelorderID
            // 
            this.labelorderID.BackColor = System.Drawing.Color.White;
            this.labelorderID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelorderID.Location = new System.Drawing.Point(258, 110);
            this.labelorderID.Name = "labelorderID";
            this.labelorderID.Size = new System.Drawing.Size(242, 25);
            this.labelorderID.TabIndex = 28;
            // 
            // comboboxorder
            // 
            this.comboboxorder.FormattingEnabled = true;
            this.comboboxorder.Location = new System.Drawing.Point(258, 170);
            this.comboboxorder.Name = "comboboxorder";
            this.comboboxorder.Size = new System.Drawing.Size(242, 24);
            this.comboboxorder.TabIndex = 27;
            this.comboboxorder.SelectedIndexChanged += new System.EventHandler(this.comboboxorder_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(49, 290);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(200, 38);
            this.label11.TabIndex = 26;
            this.label11.Text = "Customer Name:";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(49, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(200, 38);
            this.label10.TabIndex = 25;
            this.label10.Text = "ID:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(49, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 38);
            this.label9.TabIndex = 24;
            this.label9.Text = "Product:";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(49, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 38);
            this.label8.TabIndex = 23;
            this.label8.Text = "Price:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(269, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 38);
            this.label7.TabIndex = 22;
            this.label7.Text = "ADD ORDER";
            // 
            // paneltransaction
            // 
            this.paneltransaction.Controls.Add(this.buttontransactionmenu);
            this.paneltransaction.Controls.Add(this.labeltransactions);
            this.paneltransaction.Controls.Add(this.label13);
            this.paneltransaction.Controls.Add(this.label12);
            this.paneltransaction.Location = new System.Drawing.Point(0, 0);
            this.paneltransaction.Name = "paneltransaction";
            this.paneltransaction.Size = new System.Drawing.Size(796, 470);
            this.paneltransaction.TabIndex = 7;
            // 
            // buttontransactionmenu
            // 
            this.buttontransactionmenu.Location = new System.Drawing.Point(588, 393);
            this.buttontransactionmenu.Name = "buttontransactionmenu";
            this.buttontransactionmenu.Size = new System.Drawing.Size(167, 49);
            this.buttontransactionmenu.TabIndex = 26;
            this.buttontransactionmenu.Text = "MAIN MENU";
            this.buttontransactionmenu.UseVisualStyleBackColor = true;
            this.buttontransactionmenu.Click += new System.EventHandler(this.buttontransactionmenu_Click);
            // 
            // labeltransactions
            // 
            this.labeltransactions.BackColor = System.Drawing.Color.White;
            this.labeltransactions.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltransactions.Location = new System.Drawing.Point(118, 134);
            this.labeltransactions.Name = "labeltransactions";
            this.labeltransactions.Size = new System.Drawing.Size(564, 235);
            this.labeltransactions.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(62, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(200, 38);
            this.label13.TabIndex = 24;
            this.label13.Text = "All Transactions:";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(272, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(200, 38);
            this.label12.TabIndex = 23;
            this.label12.Text = "TRANSACTIONS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.paneladdorder);
            this.Controls.Add(this.paneladdproduct);
            this.Controls.Add(this.panelwelcome);
            this.Controls.Add(this.paneltransaction);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelwelcome.ResumeLayout(false);
            this.paneladdproduct.ResumeLayout(false);
            this.paneladdproduct.PerformLayout();
            this.paneladdorder.ResumeLayout(false);
            this.paneladdorder.PerformLayout();
            this.paneltransaction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonaddorder;
        private System.Windows.Forms.Button buttonaddproduct;
        private System.Windows.Forms.Button buttontransaction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelwelcome;
        private System.Windows.Forms.Panel paneladdproduct;
        private System.Windows.Forms.TextBox textboxproductdescription;
        private System.Windows.Forms.TextBox textboxproductprice;
        private System.Windows.Forms.TextBox textboxproductname;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonMainMenu;
        private System.Windows.Forms.Button buttonsubmitproduct;
        private System.Windows.Forms.Panel paneladdorder;
        private System.Windows.Forms.TextBox textboxcustomername;
        private System.Windows.Forms.Label labelorderprice;
        private System.Windows.Forms.Label labelorderID;
        private System.Windows.Forms.ComboBox comboboxorder;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonsaveneworder;
        private System.Windows.Forms.Button buttonordermainmenu;
        private System.Windows.Forms.Panel paneltransaction;
        private System.Windows.Forms.Label labeltransactions;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttontransactionmenu;
    }
}

