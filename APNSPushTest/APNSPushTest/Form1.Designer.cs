namespace APNSPushTest
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナ変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナで生成されたコード

		/// <summary>
		/// デザイナ サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディタで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbCount = new System.Windows.Forms.ComboBox();
			this.txtDeviceToken = new System.Windows.Forms.TextBox();
			this.txtMessage = new System.Windows.Forms.TextBox();
			this.btnPush = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(87, 124);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 15);
			this.label3.TabIndex = 13;
			this.label3.Text = "カウント";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(73, 78);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 15);
			this.label2.TabIndex = 12;
			this.label2.Text = "メッセージ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(36, 22);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 15);
			this.label1.TabIndex = 11;
			this.label1.Text = "デバイストークン";
			// 
			// cmbCount
			// 
			this.cmbCount.FormattingEnabled = true;
			this.cmbCount.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
			this.cmbCount.Location = new System.Drawing.Point(148, 120);
			this.cmbCount.Margin = new System.Windows.Forms.Padding(4);
			this.cmbCount.Name = "cmbCount";
			this.cmbCount.Size = new System.Drawing.Size(160, 23);
			this.cmbCount.TabIndex = 10;
			// 
			// txtDeviceToken
			// 
			this.txtDeviceToken.Location = new System.Drawing.Point(148, 19);
			this.txtDeviceToken.Margin = new System.Windows.Forms.Padding(4);
			this.txtDeviceToken.Name = "txtDeviceToken";
			this.txtDeviceToken.Size = new System.Drawing.Size(393, 22);
			this.txtDeviceToken.TabIndex = 9;
			// 
			// txtMessage
			// 
			this.txtMessage.Location = new System.Drawing.Point(148, 74);
			this.txtMessage.Margin = new System.Windows.Forms.Padding(4);
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.Size = new System.Drawing.Size(272, 22);
			this.txtMessage.TabIndex = 8;
			// 
			// btnPush
			// 
			this.btnPush.Location = new System.Drawing.Point(148, 191);
			this.btnPush.Margin = new System.Windows.Forms.Padding(4);
			this.btnPush.Name = "btnPush";
			this.btnPush.Size = new System.Drawing.Size(181, 29);
			this.btnPush.TabIndex = 7;
			this.btnPush.Text = "プッシュ通知実行";
			this.btnPush.UseVisualStyleBackColor = true;
			this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(576, 252);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbCount);
			this.Controls.Add(this.txtDeviceToken);
			this.Controls.Add(this.txtMessage);
			this.Controls.Add(this.btnPush);
			this.Name = "Form1";
			this.Text = "プッシュ通知のテスト";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbCount;
		private System.Windows.Forms.TextBox txtDeviceToken;
		private System.Windows.Forms.TextBox txtMessage;
		private System.Windows.Forms.Button btnPush;
	}
}

