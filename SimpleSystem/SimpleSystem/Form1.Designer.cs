namespace SimpleSystem
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
            label1 = new Label();
            name = new TextBox();
            mythology = new TextBox();
            label2 = new Label();
            label3 = new Label();
            isImmortal = new CheckBox();
            children = new NumericUpDown();
            gods = new DataGridView();
            create = new Button();
            delete = new Button();
            update = new Button();
            ((System.ComponentModel.ISupportInitialize)children).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gods).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 15);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 0;
            label1.Text = "Име:";
            // 
            // name
            // 
            name.Location = new Point(114, 12);
            name.Name = "name";
            name.Size = new Size(150, 27);
            name.TabIndex = 1;
            // 
            // mythology
            // 
            mythology.Location = new Point(114, 45);
            mythology.Name = "mythology";
            mythology.Size = new Size(150, 27);
            mythology.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 48);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 2;
            label2.Text = "Митология: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 81);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 4;
            label3.Text = "Брой деца:";
            // 
            // isImmortal
            // 
            isImmortal.AutoSize = true;
            isImmortal.Location = new Point(15, 111);
            isImmortal.Name = "isImmortal";
            isImmortal.Size = new Size(114, 24);
            isImmortal.TabIndex = 6;
            isImmortal.Text = "Безсмъртен";
            isImmortal.UseVisualStyleBackColor = true;
            // 
            // children
            // 
            children.Location = new Point(114, 81);
            children.Name = "children";
            children.Size = new Size(150, 27);
            children.TabIndex = 7;
            // 
            // gods
            // 
            gods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gods.Location = new Point(15, 141);
            gods.Name = "gods";
            gods.RowHeadersWidth = 51;
            gods.RowTemplate.Height = 29;
            gods.Size = new Size(772, 297);
            gods.TabIndex = 8;
            // 
            // create
            // 
            create.Location = new Point(306, 11);
            create.Name = "create";
            create.Size = new Size(94, 29);
            create.TabIndex = 9;
            create.Text = "Добави";
            create.UseVisualStyleBackColor = true;
            create.Click += add_Click;
            // 
            // delete
            // 
            delete.Location = new Point(306, 44);
            delete.Name = "delete";
            delete.Size = new Size(94, 29);
            delete.TabIndex = 10;
            delete.Text = "Премахни";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // update
            // 
            update.Location = new Point(306, 81);
            update.Name = "update";
            update.Size = new Size(94, 29);
            update.TabIndex = 11;
            update.Text = "Промени";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 450);
            Controls.Add(update);
            Controls.Add(delete);
            Controls.Add(create);
            Controls.Add(gods);
            Controls.Add(children);
            Controls.Add(isImmortal);
            Controls.Add(label3);
            Controls.Add(mythology);
            Controls.Add(label2);
            Controls.Add(name);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)children).EndInit();
            ((System.ComponentModel.ISupportInitialize)gods).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox name;
        private TextBox mythology;
        private Label label2;
        private Label label3;
        private CheckBox isImmortal;
        private NumericUpDown children;
        private DataGridView gods;
        private Button create;
        private Button delete;
        private Button update;
    }
}