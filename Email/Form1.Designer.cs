namespace Email;

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
        textBoxTo = new TextBox();
        label2 = new Label();
        textBoxSubject = new TextBox();
        textBoxBody = new TextBox();
        label3 = new Label();
        buttonSend = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(74, 38);
        label1.Name = "label1";
        label1.Size = new Size(22, 15);
        label1.TabIndex = 1;
        label1.Text = "To:";
        // 
        // textBoxTo
        // 
        textBoxTo.Location = new Point(129, 35);
        textBoxTo.Name = "textBoxTo";
        textBoxTo.Size = new Size(351, 23);
        textBoxTo.TabIndex = 2;
        textBoxTo.Text = "test@test.com";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(74, 71);
        label2.Name = "label2";
        label2.Size = new Size(46, 15);
        label2.TabIndex = 3;
        label2.Text = "Subject";
        // 
        // textBoxSubject
        // 
        textBoxSubject.Location = new Point(129, 68);
        textBoxSubject.Name = "textBoxSubject";
        textBoxSubject.Size = new Size(351, 23);
        textBoxSubject.TabIndex = 4;
        textBoxSubject.Text = "test";
        textBoxSubject.TextChanged += textBoxSubject_TextChanged;
        // 
        // textBoxBody
        // 
        textBoxBody.Location = new Point(129, 106);
        textBoxBody.Multiline = true;
        textBoxBody.Name = "textBoxBody";
        textBoxBody.Size = new Size(351, 120);
        textBoxBody.TabIndex = 5;
        textBoxBody.Text = "salam";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(74, 106);
        label3.Name = "label3";
        label3.Size = new Size(34, 15);
        label3.TabIndex = 6;
        label3.Text = "Body";
        // 
        // buttonSend
        // 
        buttonSend.Location = new Point(405, 246);
        buttonSend.Name = "buttonSend";
        buttonSend.Size = new Size(75, 23);
        buttonSend.TabIndex = 7;
        buttonSend.Text = "Send";
        buttonSend.UseVisualStyleBackColor = true;
        buttonSend.Click += buttonSend_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(buttonSend);
        Controls.Add(label3);
        Controls.Add(textBoxBody);
        Controls.Add(textBoxSubject);
        Controls.Add(label2);
        Controls.Add(textBoxTo);
        Controls.Add(label1);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox textBoxTo;
    private Label label2;
    private TextBox textBoxSubject;
    private TextBox textBoxBody;
    private Label label3;
    private Button buttonSend;
}
