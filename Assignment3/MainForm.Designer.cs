namespace Assignment3
{
    partial class MainForm
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
            this.ok = new System.Windows.Forms.Button();
            this.InputBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.rbtnCancelReserve = new System.Windows.Forms.RadioButton();
            this.rbtnReserved = new System.Windows.Forms.RadioButton();
            this.OutputBox = new System.Windows.Forms.GroupBox();
            this.textVacantSeat = new System.Windows.Forms.TextBox();
            this.textReservedSeat = new System.Windows.Forms.TextBox();
            this.textTotalSeat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.reservationListBox = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.InputBox.SuspendLayout();
            this.OutputBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ok
            // 
            this.ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok.Location = new System.Drawing.Point(87, 121);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(149, 23);
            this.ok.TabIndex = 3;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.button1_Click);
            // 
            // InputBox
            // 
            this.InputBox.Controls.Add(this.label2);
            this.InputBox.Controls.Add(this.label1);
            this.InputBox.Controls.Add(this.textPrice);
            this.InputBox.Controls.Add(this.textName);
            this.InputBox.Controls.Add(this.rbtnCancelReserve);
            this.InputBox.Controls.Add(this.rbtnReserved);
            this.InputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.InputBox.Location = new System.Drawing.Point(12, 13);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(303, 102);
            this.InputBox.TabIndex = 4;
            this.InputBox.TabStop = false;
            this.InputBox.Text = "Booking Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(206, 74);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(91, 21);
            this.textPrice.TabIndex = 3;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(7, 74);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(185, 21);
            this.textName.TabIndex = 2;
            // 
            // rbtnCancelReserve
            // 
            this.rbtnCancelReserve.AutoSize = true;
            this.rbtnCancelReserve.Location = new System.Drawing.Point(166, 20);
            this.rbtnCancelReserve.Name = "rbtnCancelReserve";
            this.rbtnCancelReserve.Size = new System.Drawing.Size(131, 19);
            this.rbtnCancelReserve.TabIndex = 1;
            this.rbtnCancelReserve.TabStop = true;
            this.rbtnCancelReserve.Text = "Cancel Reservation";
            this.rbtnCancelReserve.UseVisualStyleBackColor = true;
            // 
            // rbtnReserved
            // 
            this.rbtnReserved.AutoSize = true;
            this.rbtnReserved.Location = new System.Drawing.Point(7, 20);
            this.rbtnReserved.Name = "rbtnReserved";
            this.rbtnReserved.Size = new System.Drawing.Size(70, 19);
            this.rbtnReserved.TabIndex = 0;
            this.rbtnReserved.TabStop = true;
            this.rbtnReserved.Text = "Reserve";
            this.rbtnReserved.UseVisualStyleBackColor = true;
            this.rbtnReserved.CheckedChanged += new System.EventHandler(this.rbtnReserved_CheckedChanged);
            // 
            // OutputBox
            // 
            this.OutputBox.Controls.Add(this.textVacantSeat);
            this.OutputBox.Controls.Add(this.textReservedSeat);
            this.OutputBox.Controls.Add(this.textTotalSeat);
            this.OutputBox.Controls.Add(this.label5);
            this.OutputBox.Controls.Add(this.label4);
            this.OutputBox.Controls.Add(this.label3);
            this.OutputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputBox.Location = new System.Drawing.Point(13, 159);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(302, 120);
            this.OutputBox.TabIndex = 5;
            this.OutputBox.TabStop = false;
            this.OutputBox.Text = "Output Data";
            this.OutputBox.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // textVacantSeat
            // 
            this.textVacantSeat.Location = new System.Drawing.Point(196, 93);
            this.textVacantSeat.Name = "textVacantSeat";
            this.textVacantSeat.Size = new System.Drawing.Size(100, 21);
            this.textVacantSeat.TabIndex = 5;
            // 
            // textReservedSeat
            // 
            this.textReservedSeat.Location = new System.Drawing.Point(196, 63);
            this.textReservedSeat.Name = "textReservedSeat";
            this.textReservedSeat.Size = new System.Drawing.Size(100, 21);
            this.textReservedSeat.TabIndex = 4;
            // 
            // textTotalSeat
            // 
            this.textTotalSeat.Enabled = false;
            this.textTotalSeat.Location = new System.Drawing.Point(196, 34);
            this.textTotalSeat.Name = "textTotalSeat";
            this.textTotalSeat.Size = new System.Drawing.Size(100, 21);
            this.textTotalSeat.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Number of vacant seats";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Number of reserved seats";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total number of seats";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.reservationListBox);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(321, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(413, 266);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reservations";
            // 
            // reservationListBox
            // 
            this.reservationListBox.FormattingEnabled = true;
            this.reservationListBox.ItemHeight = 15;
            this.reservationListBox.Location = new System.Drawing.Point(6, 46);
            this.reservationListBox.Name = "reservationListBox";
            this.reservationListBox.Size = new System.Drawing.Size(401, 214);
            this.reservationListBox.TabIndex = 5;
            this.reservationListBox.SelectedIndexChanged += new System.EventHandler(this.reservationListBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(275, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(185, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Seat";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 290);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.ok);
            this.Name = "MainForm";
            this.Text = "Apu Ticket Reservation";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.InputBox.ResumeLayout(false);
            this.InputBox.PerformLayout();
            this.OutputBox.ResumeLayout(false);
            this.OutputBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.GroupBox InputBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.RadioButton rbtnCancelReserve;
        private System.Windows.Forms.RadioButton rbtnReserved;
        private System.Windows.Forms.GroupBox OutputBox;
        private System.Windows.Forms.TextBox textVacantSeat;
        private System.Windows.Forms.TextBox textReservedSeat;
        private System.Windows.Forms.TextBox textTotalSeat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox reservationListBox;
    }
}

