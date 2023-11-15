namespace ManagerApp
{
    partial class FormDashboard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            tabControlDashboard = new TabControl();
            tabPageHome = new TabPage();
            label2 = new Label();
            label1 = new Label();
            tabPageWater = new TabPage();
            groupBoxData = new GroupBox();
            listViewWaterBill = new ListView();
            groupBoxUser = new GroupBox();
            btnClear = new Button();
            btnRemove = new Button();
            btnAdd = new Button();
            txtWaterCurrentMonth = new TextBox();
            label7 = new Label();
            txtWaterLastMonth = new TextBox();
            label6 = new Label();
            txtPeople = new TextBox();
            label5 = new Label();
            cboCustomerType = new ComboBox();
            label4 = new Label();
            txtCustomer = new TextBox();
            label3 = new Label();
            tabPageExit = new TabPage();
            button1 = new Button();
            imageListTabPage = new ImageList(components);
            tabControlDashboard.SuspendLayout();
            tabPageHome.SuspendLayout();
            tabPageWater.SuspendLayout();
            groupBoxData.SuspendLayout();
            groupBoxUser.SuspendLayout();
            tabPageExit.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlDashboard
            // 
            tabControlDashboard.Controls.Add(tabPageHome);
            tabControlDashboard.Controls.Add(tabPageWater);
            tabControlDashboard.Controls.Add(tabPageExit);
            tabControlDashboard.Dock = DockStyle.Fill;
            tabControlDashboard.ImageList = imageListTabPage;
            tabControlDashboard.Location = new Point(0, 0);
            tabControlDashboard.Name = "tabControlDashboard";
            tabControlDashboard.SelectedIndex = 0;
            tabControlDashboard.Size = new Size(800, 450);
            tabControlDashboard.TabIndex = 0;
            // 
            // tabPageHome
            // 
            tabPageHome.Controls.Add(label2);
            tabPageHome.Controls.Add(label1);
            tabPageHome.ImageIndex = 0;
            tabPageHome.Location = new Point(4, 39);
            tabPageHome.Name = "tabPageHome";
            tabPageHome.Padding = new Padding(3);
            tabPageHome.Size = new Size(792, 407);
            tabPageHome.TabIndex = 0;
            tabPageHome.Text = "Home";
            tabPageHome.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.AppWorkspace;
            label2.Location = new Point(300, 55);
            label2.Name = "label2";
            label2.Size = new Size(196, 30);
            label2.TabIndex = 1;
            label2.Text = "Water Bill software";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(317, 23);
            label1.Name = "label1";
            label1.Size = new Size(169, 32);
            label1.TabIndex = 0;
            label1.Text = "Welcome You";
            // 
            // tabPageWater
            // 
            tabPageWater.Controls.Add(groupBoxData);
            tabPageWater.Controls.Add(groupBoxUser);
            tabPageWater.ImageIndex = 1;
            tabPageWater.Location = new Point(4, 39);
            tabPageWater.Name = "tabPageWater";
            tabPageWater.Padding = new Padding(3);
            tabPageWater.Size = new Size(792, 407);
            tabPageWater.TabIndex = 1;
            tabPageWater.Text = "Water Bill";
            tabPageWater.UseVisualStyleBackColor = true;
            // 
            // groupBoxData
            // 
            groupBoxData.Controls.Add(listViewWaterBill);
            groupBoxData.Location = new Point(10, 205);
            groupBoxData.Name = "groupBoxData";
            groupBoxData.Size = new Size(774, 194);
            groupBoxData.TabIndex = 1;
            groupBoxData.TabStop = false;
            groupBoxData.Text = "Data";
            // 
            // listViewWaterBill
            // 
            listViewWaterBill.Location = new Point(6, 22);
            listViewWaterBill.Name = "listViewWaterBill";
            listViewWaterBill.Size = new Size(762, 166);
            listViewWaterBill.TabIndex = 0;
            listViewWaterBill.UseCompatibleStateImageBehavior = false;
            // 
            // groupBoxUser
            // 
            groupBoxUser.Controls.Add(btnClear);
            groupBoxUser.Controls.Add(btnRemove);
            groupBoxUser.Controls.Add(btnAdd);
            groupBoxUser.Controls.Add(txtWaterCurrentMonth);
            groupBoxUser.Controls.Add(label7);
            groupBoxUser.Controls.Add(txtWaterLastMonth);
            groupBoxUser.Controls.Add(label6);
            groupBoxUser.Controls.Add(txtPeople);
            groupBoxUser.Controls.Add(label5);
            groupBoxUser.Controls.Add(cboCustomerType);
            groupBoxUser.Controls.Add(label4);
            groupBoxUser.Controls.Add(txtCustomer);
            groupBoxUser.Controls.Add(label3);
            groupBoxUser.Location = new Point(8, 8);
            groupBoxUser.Name = "groupBoxUser";
            groupBoxUser.Size = new Size(776, 178);
            groupBoxUser.TabIndex = 0;
            groupBoxUser.TabStop = false;
            groupBoxUser.Text = "User's information";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(695, 126);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 30);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(533, 126);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(102, 30);
            btnRemove.TabIndex = 11;
            btnRemove.Text = "Remove Item";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(443, 126);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 30);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add +";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtWaterCurrentMonth
            // 
            txtWaterCurrentMonth.Location = new Point(560, 74);
            txtWaterCurrentMonth.Name = "txtWaterCurrentMonth";
            txtWaterCurrentMonth.Size = new Size(189, 23);
            txtWaterCurrentMonth.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(424, 82);
            label7.Name = "label7";
            label7.Size = new Size(118, 15);
            label7.TabIndex = 8;
            label7.Text = "Water current month";
            // 
            // txtWaterLastMonth
            // 
            txtWaterLastMonth.Location = new Point(560, 27);
            txtWaterLastMonth.Name = "txtWaterLastMonth";
            txtWaterLastMonth.Size = new Size(189, 23);
            txtWaterLastMonth.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(446, 35);
            label6.Name = "label6";
            label6.Size = new Size(98, 15);
            label6.TabIndex = 6;
            label6.Text = "Water last month";
            // 
            // txtPeople
            // 
            txtPeople.Enabled = false;
            txtPeople.Location = new Point(141, 125);
            txtPeople.Name = "txtPeople";
            txtPeople.Size = new Size(243, 23);
            txtPeople.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(86, 133);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 4;
            label5.Text = "People";
            // 
            // cboCustomerType
            // 
            cboCustomerType.FormattingEnabled = true;
            cboCustomerType.Items.AddRange(new object[] { "Household", "Administrative", "Production", "Business" });
            cboCustomerType.Location = new Point(141, 79);
            cboCustomerType.Name = "cboCustomerType";
            cboCustomerType.Size = new Size(246, 23);
            cboCustomerType.TabIndex = 3;
            cboCustomerType.SelectedIndexChanged += cboCustomerType_SelectedIndexChanged;
            cboCustomerType.DropDownClosed += cboCustomerType_DropDownClosed;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 87);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 2;
            label4.Text = "Customer type";
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(141, 27);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(248, 23);
            txtCustomer.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 35);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 0;
            label3.Text = "Customer";
            label3.Click += label3_Click;
            // 
            // tabPageExit
            // 
            tabPageExit.Controls.Add(button1);
            tabPageExit.ImageIndex = 2;
            tabPageExit.Location = new Point(4, 39);
            tabPageExit.Name = "tabPageExit";
            tabPageExit.Padding = new Padding(3);
            tabPageExit.Size = new Size(792, 407);
            tabPageExit.TabIndex = 2;
            tabPageExit.Text = "Exit Application";
            tabPageExit.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(288, 23);
            button1.Name = "button1";
            button1.Size = new Size(198, 60);
            button1.TabIndex = 0;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // imageListTabPage
            // 
            imageListTabPage.ColorDepth = ColorDepth.Depth8Bit;
            imageListTabPage.ImageStream = (ImageListStreamer)resources.GetObject("imageListTabPage.ImageStream");
            imageListTabPage.TransparentColor = Color.Transparent;
            imageListTabPage.Images.SetKeyName(0, "Home-icon.png");
            imageListTabPage.Images.SetKeyName(1, "Bill-icon.png");
            imageListTabPage.Images.SetKeyName(2, "Users-Exit-icon.png");
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControlDashboard);
            Name = "FormDashboard";
            Text = "Dashboard";
            Load += FormDashboard_Load;
            tabControlDashboard.ResumeLayout(false);
            tabPageHome.ResumeLayout(false);
            tabPageHome.PerformLayout();
            tabPageWater.ResumeLayout(false);
            groupBoxData.ResumeLayout(false);
            groupBoxUser.ResumeLayout(false);
            groupBoxUser.PerformLayout();
            tabPageExit.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlDashboard;
        private TabPage tabPageHome;
        private TabPage tabPageWater;
        private ImageList imageListTabPage;
        private Label label2;
        private Label label1;
        private TabPage tabPageExit;
        private Button button1;
        private GroupBox groupBoxUser;
        private Label label4;
        private TextBox txtCustomer;
        private Label label3;
        private Label label5;
        private ComboBox cboCustomerType;
        private TextBox txtWaterLastMonth;
        private Label label6;
        private TextBox txtPeople;
        private Button btnClear;
        private Button btnRemove;
        private Button btnAdd;
        private TextBox txtWaterCurrentMonth;
        private Label label7;
        private GroupBox groupBoxData;
        private ListView listViewWaterBill;
    }
}