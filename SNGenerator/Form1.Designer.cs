namespace SNGenerator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPartNo = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtPONo = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.DG = new System.Windows.Forms.DataGridView();
            this.btnScan = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSeqNo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Part No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Brand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "PO No.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Year";
            // 
            // txtPartNo
            // 
            this.txtPartNo.Location = new System.Drawing.Point(84, 38);
            this.txtPartNo.Name = "txtPartNo";
            this.txtPartNo.Size = new System.Drawing.Size(124, 20);
            this.txtPartNo.TabIndex = 4;
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(84, 64);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(124, 20);
            this.txtBrand.TabIndex = 5;
            // 
            // txtPONo
            // 
            this.txtPONo.Location = new System.Drawing.Point(84, 90);
            this.txtPONo.Name = "txtPONo";
            this.txtPONo.Size = new System.Drawing.Size(124, 20);
            this.txtPONo.TabIndex = 6;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(84, 116);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(124, 20);
            this.txtYear.TabIndex = 7;
            this.txtYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtYear_KeyDown);
            this.txtYear.Leave += new System.EventHandler(this.txtYear_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Seq No.";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(84, 142);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(124, 20);
            this.txtQty.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(35, 212);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(173, 34);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // DG
            // 
            this.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG.Location = new System.Drawing.Point(214, 38);
            this.DG.Name = "DG";
            this.DG.Size = new System.Drawing.Size(352, 273);
            this.DG.TabIndex = 11;
            // 
            // btnScan
            // 
            this.btnScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScan.Location = new System.Drawing.Point(593, 307);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 72);
            this.btnScan.TabIndex = 12;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(691, 307);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 72);
            this.btnStop.TabIndex = 13;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(593, 385);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(173, 20);
            this.txtBarcode.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Quantuty";
            // 
            // txtSeqNo
            // 
            this.txtSeqNo.Location = new System.Drawing.Point(84, 168);
            this.txtSeqNo.Name = "txtSeqNo";
            this.txtSeqNo.Size = new System.Drawing.Size(124, 20);
            this.txtSeqNo.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 34);
            this.button1.TabIndex = 17;
            this.button1.Text = "Clear Grid";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSeqNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.DG);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtPONo);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.txtPartNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPartNo;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtPONo;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView DG;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSeqNo;
        private System.Windows.Forms.Button button1;
    }
}

