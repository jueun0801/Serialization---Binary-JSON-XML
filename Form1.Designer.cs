namespace Assignment_5._4_Serialization
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpBinary = new System.Windows.Forms.GroupBox();
            this.btnBinaryDS = new System.Windows.Forms.Button();
            this.btnBinarySer = new System.Windows.Forms.Button();
            this.linkBinary = new System.Windows.Forms.LinkLabel();
            this.grpJSON = new System.Windows.Forms.GroupBox();
            this.btnJSONDS = new System.Windows.Forms.Button();
            this.btnJSONSer = new System.Windows.Forms.Button();
            this.linkJSON = new System.Windows.Forms.LinkLabel();
            this.grpXML = new System.Windows.Forms.GroupBox();
            this.btnXMLDS = new System.Windows.Forms.Button();
            this.btnXMLSer = new System.Windows.Forms.Button();
            this.linkXML = new System.Windows.Forms.LinkLabel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.grpBinary.SuspendLayout();
            this.grpJSON.SuspendLayout();
            this.grpXML.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBinary
            // 
            this.grpBinary.BackColor = System.Drawing.Color.AntiqueWhite;
            this.grpBinary.Controls.Add(this.btnBinaryDS);
            this.grpBinary.Controls.Add(this.btnBinarySer);
            this.grpBinary.Controls.Add(this.linkBinary);
            this.grpBinary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpBinary.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBinary.Location = new System.Drawing.Point(36, 192);
            this.grpBinary.Name = "grpBinary";
            this.grpBinary.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpBinary.Size = new System.Drawing.Size(165, 165);
            this.grpBinary.TabIndex = 4;
            this.grpBinary.TabStop = false;
            this.grpBinary.Text = "             BINARY";
            // 
            // btnBinaryDS
            // 
            this.btnBinaryDS.BackColor = System.Drawing.Color.Black;
            this.btnBinaryDS.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.btnBinaryDS.FlatAppearance.BorderSize = 2;
            this.btnBinaryDS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OliveDrab;
            this.btnBinaryDS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBinaryDS.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBinaryDS.ForeColor = System.Drawing.Color.LightGray;
            this.btnBinaryDS.Location = new System.Drawing.Point(36, 84);
            this.btnBinaryDS.Name = "btnBinaryDS";
            this.btnBinaryDS.Size = new System.Drawing.Size(96, 25);
            this.btnBinaryDS.TabIndex = 6;
            this.btnBinaryDS.Text = "Deserialize";
            this.btnBinaryDS.UseVisualStyleBackColor = false;
            this.btnBinaryDS.Click += new System.EventHandler(this.btnBinaryDS_Click);
            // 
            // btnBinarySer
            // 
            this.btnBinarySer.BackColor = System.Drawing.Color.Black;
            this.btnBinarySer.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.btnBinarySer.FlatAppearance.BorderSize = 2;
            this.btnBinarySer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OliveDrab;
            this.btnBinarySer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBinarySer.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBinarySer.ForeColor = System.Drawing.Color.LightGray;
            this.btnBinarySer.Location = new System.Drawing.Point(36, 36);
            this.btnBinarySer.Name = "btnBinarySer";
            this.btnBinarySer.Size = new System.Drawing.Size(96, 25);
            this.btnBinarySer.TabIndex = 5;
            this.btnBinarySer.Text = "Serialize";
            this.btnBinarySer.UseVisualStyleBackColor = false;
            this.btnBinarySer.Click += new System.EventHandler(this.btnBinarySer_Click);
            // 
            // linkBinary
            // 
            this.linkBinary.AutoSize = true;
            this.linkBinary.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkBinary.Location = new System.Drawing.Point(3, 132);
            this.linkBinary.Name = "linkBinary";
            this.linkBinary.Size = new System.Drawing.Size(159, 13);
            this.linkBinary.TabIndex = 7;
            this.linkBinary.TabStop = true;
            this.linkBinary.Text = "Learn more about Binary!";
            this.linkBinary.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBinary_LinkClicked);
            // 
            // grpJSON
            // 
            this.grpJSON.BackColor = System.Drawing.Color.AntiqueWhite;
            this.grpJSON.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpJSON.Controls.Add(this.btnJSONDS);
            this.grpJSON.Controls.Add(this.btnJSONSer);
            this.grpJSON.Controls.Add(this.linkJSON);
            this.grpJSON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpJSON.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpJSON.Location = new System.Drawing.Point(240, 192);
            this.grpJSON.Name = "grpJSON";
            this.grpJSON.Size = new System.Drawing.Size(165, 165);
            this.grpJSON.TabIndex = 8;
            this.grpJSON.TabStop = false;
            this.grpJSON.Text = "              JSON";
            // 
            // btnJSONDS
            // 
            this.btnJSONDS.BackColor = System.Drawing.Color.Black;
            this.btnJSONDS.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.btnJSONDS.FlatAppearance.BorderSize = 2;
            this.btnJSONDS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OliveDrab;
            this.btnJSONDS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.btnJSONDS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJSONDS.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJSONDS.ForeColor = System.Drawing.Color.LightGray;
            this.btnJSONDS.Location = new System.Drawing.Point(36, 84);
            this.btnJSONDS.Name = "btnJSONDS";
            this.btnJSONDS.Size = new System.Drawing.Size(96, 25);
            this.btnJSONDS.TabIndex = 10;
            this.btnJSONDS.Text = "Deserialize";
            this.btnJSONDS.UseVisualStyleBackColor = false;
            this.btnJSONDS.Click += new System.EventHandler(this.btnJSONDS_Click);
            // 
            // btnJSONSer
            // 
            this.btnJSONSer.BackColor = System.Drawing.Color.Black;
            this.btnJSONSer.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.btnJSONSer.FlatAppearance.BorderSize = 2;
            this.btnJSONSer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OliveDrab;
            this.btnJSONSer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.btnJSONSer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJSONSer.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJSONSer.ForeColor = System.Drawing.Color.LightGray;
            this.btnJSONSer.Location = new System.Drawing.Point(36, 36);
            this.btnJSONSer.Name = "btnJSONSer";
            this.btnJSONSer.Size = new System.Drawing.Size(96, 25);
            this.btnJSONSer.TabIndex = 9;
            this.btnJSONSer.Text = "Serialize";
            this.btnJSONSer.UseVisualStyleBackColor = false;
            this.btnJSONSer.Click += new System.EventHandler(this.btnJSONSer_Click);
            // 
            // linkJSON
            // 
            this.linkJSON.AutoSize = true;
            this.linkJSON.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkJSON.Location = new System.Drawing.Point(12, 132);
            this.linkJSON.Name = "linkJSON";
            this.linkJSON.Size = new System.Drawing.Size(145, 13);
            this.linkJSON.TabIndex = 11;
            this.linkJSON.TabStop = true;
            this.linkJSON.Text = "Learn more about JSON!";
            this.linkJSON.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkJSON_LinkClicked);
            // 
            // grpXML
            // 
            this.grpXML.BackColor = System.Drawing.Color.AntiqueWhite;
            this.grpXML.Controls.Add(this.btnXMLDS);
            this.grpXML.Controls.Add(this.btnXMLSer);
            this.grpXML.Controls.Add(this.linkXML);
            this.grpXML.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpXML.Location = new System.Drawing.Point(444, 192);
            this.grpXML.Name = "grpXML";
            this.grpXML.Size = new System.Drawing.Size(165, 165);
            this.grpXML.TabIndex = 12;
            this.grpXML.TabStop = false;
            this.grpXML.Text = "                XML";
            // 
            // btnXMLDS
            // 
            this.btnXMLDS.BackColor = System.Drawing.Color.Black;
            this.btnXMLDS.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.btnXMLDS.FlatAppearance.BorderSize = 2;
            this.btnXMLDS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OliveDrab;
            this.btnXMLDS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.btnXMLDS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXMLDS.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXMLDS.ForeColor = System.Drawing.Color.LightGray;
            this.btnXMLDS.Location = new System.Drawing.Point(36, 84);
            this.btnXMLDS.Name = "btnXMLDS";
            this.btnXMLDS.Size = new System.Drawing.Size(96, 25);
            this.btnXMLDS.TabIndex = 14;
            this.btnXMLDS.Text = "Deserialize";
            this.btnXMLDS.UseVisualStyleBackColor = false;
            this.btnXMLDS.Click += new System.EventHandler(this.btnXMLDS_Click);
            // 
            // btnXMLSer
            // 
            this.btnXMLSer.BackColor = System.Drawing.Color.Black;
            this.btnXMLSer.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.btnXMLSer.FlatAppearance.BorderSize = 2;
            this.btnXMLSer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OliveDrab;
            this.btnXMLSer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.btnXMLSer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXMLSer.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXMLSer.ForeColor = System.Drawing.Color.LightGray;
            this.btnXMLSer.Location = new System.Drawing.Point(36, 36);
            this.btnXMLSer.Name = "btnXMLSer";
            this.btnXMLSer.Size = new System.Drawing.Size(96, 25);
            this.btnXMLSer.TabIndex = 13;
            this.btnXMLSer.Text = "Serialize";
            this.btnXMLSer.UseVisualStyleBackColor = false;
            this.btnXMLSer.Click += new System.EventHandler(this.btnXMLSer_Click);
            // 
            // linkXML
            // 
            this.linkXML.AutoSize = true;
            this.linkXML.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkXML.Location = new System.Drawing.Point(15, 132);
            this.linkXML.Name = "linkXML";
            this.linkXML.Size = new System.Drawing.Size(141, 13);
            this.linkXML.TabIndex = 15;
            this.linkXML.TabStop = true;
            this.linkXML.Text = "Learn more about XML!";
            this.linkXML.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkXML_LinkClicked);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.LightGray;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(396, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(119, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.LightGray;
            this.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAge.Location = new System.Drawing.Point(396, 60);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(119, 20);
            this.txtAge.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.LightGray;
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblName.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(312, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(40, 16);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.LightGray;
            this.lblAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAge.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(312, 60);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(30, 16);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Age";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.LightGray;
            this.lblPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPhone.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(312, 96);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(49, 16);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Phone";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Black;
            this.btnCreate.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.Silver;
            this.btnCreate.Location = new System.Drawing.Point(396, 132);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(96, 36);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Serialization 101";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.LightGray;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Location = new System.Drawing.Point(396, 96);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(119, 20);
            this.txtPhone.TabIndex = 3;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(Assignment_5._4_Serialization.Person);
            // 
            // personBindingSource1
            // 
            this.personBindingSource1.DataSource = typeof(Assignment_5._4_Serialization.Person);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(644, 381);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.grpXML);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.grpJSON);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.grpBinary);
            this.Name = "Form1";
            this.Text = "Serialization";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBinary.ResumeLayout(false);
            this.grpBinary.PerformLayout();
            this.grpJSON.ResumeLayout(false);
            this.grpJSON.PerformLayout();
            this.grpXML.ResumeLayout(false);
            this.grpXML.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBinary;
        private System.Windows.Forms.LinkLabel linkBinary;
        private System.Windows.Forms.GroupBox grpJSON;
        private System.Windows.Forms.GroupBox grpXML;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.LinkLabel linkJSON;
        private System.Windows.Forms.LinkLabel linkXML;
        private System.Windows.Forms.Button btnBinaryDS;
        private System.Windows.Forms.Button btnBinarySer;
        private System.Windows.Forms.Button btnJSONDS;
        private System.Windows.Forms.Button btnJSONSer;
        private System.Windows.Forms.Button btnXMLDS;
        private System.Windows.Forms.Button btnXMLSer;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.BindingSource personBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhone;
    }
}

