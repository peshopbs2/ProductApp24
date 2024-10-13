namespace ProductApp24
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            txtPrice = new TextBox();
            label3 = new Label();
            txtQuantity = new TextBox();
            label4 = new Label();
            btnSave = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(658, 449);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(376, 22);
            label1.Name = "label1";
            label1.Size = new Size(422, 38);
            label1.TabIndex = 1;
            label1.Text = "Добре дошли в нашия магазин!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(783, 87);
            label2.Name = "label2";
            label2.Size = new Size(42, 23);
            label2.TabIndex = 2;
            label2.Text = "Име";
            // 
            // txtName
            // 
            txtName.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtName.Location = new Point(785, 114);
            txtName.Name = "txtName";
            txtName.Size = new Size(280, 30);
            txtName.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtPrice.Location = new Point(785, 196);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(280, 30);
            txtPrice.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(783, 169);
            label3.Name = "label3";
            label3.Size = new Size(47, 23);
            label3.TabIndex = 4;
            label3.Text = "Цена";
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtQuantity.Location = new Point(785, 279);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(280, 30);
            txtQuantity.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(783, 252);
            label4.Name = "label4";
            label4.Size = new Size(99, 23);
            label4.TabIndex = 6;
            label4.Text = "Количество";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Blue;
            btnSave.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(785, 344);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(280, 40);
            btnSave.TabIndex = 8;
            btnSave.Text = "Запази";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Enabled = false;
            btnDelete.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(785, 425);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(280, 40);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Изтрий";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            ClientSize = new Size(1184, 573);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(txtQuantity);
            Controls.Add(label4);
            Controls.Add(txtPrice);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox txtName;
        private TextBox txtPrice;
        private Label label3;
        private TextBox txtQuantity;
        private Label label4;
        private Button btnSave;
        private Button btnDelete;
    }
}
