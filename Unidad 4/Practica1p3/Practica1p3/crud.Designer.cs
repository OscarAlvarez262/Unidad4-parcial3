namespace Practica1p3
{
    partial class crud
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
            panel1 = new Panel();
            btnActivarC = new Button();
            btnExitC = new Button();
            btnModifyC = new Button();
            btnDeleteC = new Button();
            txtUserC = new TextBox();
            txtPasswordC = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            dataUsuarios = new DataGridView();
            Numero = new DataGridViewTextBoxColumn();
            User = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataUsuarios).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnActivarC);
            panel1.Controls.Add(btnExitC);
            panel1.Controls.Add(btnModifyC);
            panel1.Controls.Add(btnDeleteC);
            panel1.Controls.Add(txtUserC);
            panel1.Controls.Add(txtPasswordC);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(758, 156);
            panel1.TabIndex = 0;
            // 
            // btnActivarC
            // 
            btnActivarC.Enabled = false;
            btnActivarC.Location = new Point(495, 67);
            btnActivarC.Name = "btnActivarC";
            btnActivarC.Size = new Size(105, 54);
            btnActivarC.TabIndex = 7;
            btnActivarC.Text = "Activate";
            btnActivarC.UseVisualStyleBackColor = true;
            btnActivarC.Click += btnActivarC_Click;
            // 
            // btnExitC
            // 
            btnExitC.ForeColor = Color.Red;
            btnExitC.Location = new Point(606, 67);
            btnExitC.Name = "btnExitC";
            btnExitC.Size = new Size(105, 54);
            btnExitC.TabIndex = 6;
            btnExitC.Text = "Exit";
            btnExitC.UseVisualStyleBackColor = true;
            btnExitC.Click += btnExitC_Click;
            // 
            // btnModifyC
            // 
            btnModifyC.Location = new Point(495, 67);
            btnModifyC.Name = "btnModifyC";
            btnModifyC.Size = new Size(105, 54);
            btnModifyC.TabIndex = 5;
            btnModifyC.Text = "Modify";
            btnModifyC.UseVisualStyleBackColor = true;
            btnModifyC.Visible = false;
            btnModifyC.Click += btnModifyC_Click;
            // 
            // btnDeleteC
            // 
            btnDeleteC.Enabled = false;
            btnDeleteC.Location = new Point(384, 67);
            btnDeleteC.Name = "btnDeleteC";
            btnDeleteC.Size = new Size(105, 54);
            btnDeleteC.TabIndex = 4;
            btnDeleteC.Text = "Delete";
            btnDeleteC.UseVisualStyleBackColor = true;
            btnDeleteC.Click += btnDeleteC_Click;
            // 
            // txtUserC
            // 
            txtUserC.Enabled = false;
            txtUserC.Location = new Point(145, 37);
            txtUserC.Name = "txtUserC";
            txtUserC.Size = new Size(169, 27);
            txtUserC.TabIndex = 3;
            txtUserC.TextChanged += textBox2_TextChanged;
            // 
            // txtPasswordC
            // 
            txtPasswordC.Enabled = false;
            txtPasswordC.Location = new Point(145, 101);
            txtPasswordC.Name = "txtPasswordC";
            txtPasswordC.Size = new Size(169, 27);
            txtPasswordC.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 101);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 37);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "User";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataUsuarios);
            panel2.Location = new Point(12, 174);
            panel2.Name = "panel2";
            panel2.Size = new Size(758, 267);
            panel2.TabIndex = 1;
            // 
            // dataUsuarios
            // 
            dataUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataUsuarios.Columns.AddRange(new DataGridViewColumn[] { Numero, User, Password });
            dataUsuarios.Location = new Point(27, 19);
            dataUsuarios.Name = "dataUsuarios";
            dataUsuarios.RowHeadersWidth = 51;
            dataUsuarios.Size = new Size(705, 232);
            dataUsuarios.TabIndex = 0;
            dataUsuarios.CellClick += dataUsuarios_CellClick;
            dataUsuarios.CellContentClick += dataGridView1_CellContentClick;
            dataUsuarios.MouseClick += dataUsuarios_MouseClick;
            // 
            // Numero
            // 
            Numero.HeaderText = "N°";
            Numero.MinimumWidth = 6;
            Numero.Name = "Numero";
            Numero.Width = 150;
            // 
            // User
            // 
            User.HeaderText = "Usuario";
            User.MinimumWidth = 6;
            User.Name = "User";
            User.Width = 250;
            // 
            // Password
            // 
            Password.HeaderText = "Contraseña";
            Password.MinimumWidth = 6;
            Password.Name = "Password";
            Password.Width = 250;
            // 
            // crud
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximumSize = new Size(800, 500);
            MinimumSize = new Size(800, 500);
            Name = "crud";
            Text = "crud";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtUserC;
        private TextBox txtPasswordC;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Button btnExitC;
        private Button btnModifyC;
        private Button btnDeleteC;
        private DataGridView dataUsuarios;
        private DataGridViewTextBoxColumn Numero;
        private DataGridViewTextBoxColumn User;
        private DataGridViewTextBoxColumn Password;
        private Button btnActivarC;
    }
}