namespace DBMS_Lab1
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
            this.GridMechanic = new System.Windows.Forms.DataGridView();
            this.GridService = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridMechanic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridService)).BeginInit();
            this.SuspendLayout();
            // 
            // GridMechanic
            // 
            this.GridMechanic.AccessibleName = "";
            this.GridMechanic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridMechanic.Location = new System.Drawing.Point(12, 12);
            this.GridMechanic.Name = "GridMechanic";
            this.GridMechanic.RowTemplate.Height = 24;
            this.GridMechanic.Size = new System.Drawing.Size(362, 266);
            this.GridMechanic.TabIndex = 0;
            this.GridMechanic.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridMechanic_CellContentClick);
            // 
            // GridService
            // 
            this.GridService.AccessibleName = "";
            this.GridService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridService.Location = new System.Drawing.Point(428, 12);
            this.GridService.Name = "GridService";
            this.GridService.RowTemplate.Height = 24;
            this.GridService.Size = new System.Drawing.Size(360, 266);
            this.GridService.TabIndex = 1;
            this.GridService.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridService_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Linen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(517, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 63);
            this.button1.TabIndex = 2;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Linen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(83, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 63);
            this.button2.TabIndex = 3;
            this.button2.Text = "CONNECT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GridService);
            this.Controls.Add(this.GridMechanic);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GridMechanic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridService)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridMechanic;
        private System.Windows.Forms.DataGridView GridService;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

