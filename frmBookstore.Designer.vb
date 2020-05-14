<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookstore
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBookstore))
        Me.picBookstore = New System.Windows.Forms.PictureBox()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblCreditCard = New System.Windows.Forms.Label()
        Me.lblExpiration = New System.Windows.Forms.Label()
        Me.txtCardNumber = New System.Windows.Forms.MaskedTextBox()
        Me.txtExpDate = New System.Windows.Forms.MaskedTextBox()
        Me.grpStudent = New System.Windows.Forms.GroupBox()
        Me.radNo = New System.Windows.Forms.RadioButton()
        Me.radYes = New System.Windows.Forms.RadioButton()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblSoftware = New System.Windows.Forms.Label()
        Me.chkVisio = New System.Windows.Forms.CheckBox()
        Me.chkQuickBooks = New System.Windows.Forms.CheckBox()
        Me.chkProject = New System.Windows.Forms.CheckBox()
        Me.chkPowerBi = New System.Windows.Forms.CheckBox()
        Me.chkSpeedType = New System.Windows.Forms.CheckBox()
        Me.btnDailyTotal = New System.Windows.Forms.Button()
        Me.lblVisio = New System.Windows.Forms.Label()
        Me.lblQuickbooks = New System.Windows.Forms.Label()
        Me.lblProject = New System.Windows.Forms.Label()
        Me.lblPowerBi = New System.Windows.Forms.Label()
        Me.lblSpeedType = New System.Windows.Forms.Label()
        CType(Me.picBookstore, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpStudent.SuspendLayout()
        Me.SuspendLayout()
        '
        'picBookstore
        '
        Me.picBookstore.Image = CType(resources.GetObject("picBookstore.Image"), System.Drawing.Image)
        Me.picBookstore.Location = New System.Drawing.Point(1, 0)
        Me.picBookstore.Name = "picBookstore"
        Me.picBookstore.Size = New System.Drawing.Size(210, 140)
        Me.picBookstore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBookstore.TabIndex = 0
        Me.picBookstore.TabStop = False
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(217, 42)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(550, 48)
        Me.lblWelcome.TabIndex = 1
        Me.lblWelcome.Text = "Welcome to our online campus bookstore!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please enter the necessary information b" &
    "elow to continue."
        '
        'lblCreditCard
        '
        Me.lblCreditCard.AutoSize = True
        Me.lblCreditCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreditCard.Location = New System.Drawing.Point(12, 176)
        Me.lblCreditCard.Name = "lblCreditCard"
        Me.lblCreditCard.Size = New System.Drawing.Size(157, 20)
        Me.lblCreditCard.TabIndex = 2
        Me.lblCreditCard.Text = "Credit Card Number: "
        '
        'lblExpiration
        '
        Me.lblExpiration.AutoSize = True
        Me.lblExpiration.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpiration.Location = New System.Drawing.Point(12, 215)
        Me.lblExpiration.Name = "lblExpiration"
        Me.lblExpiration.Size = New System.Drawing.Size(122, 20)
        Me.lblExpiration.TabIndex = 3
        Me.lblExpiration.Text = "Expiration Date:"
        '
        'txtCardNumber
        '
        Me.txtCardNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardNumber.Location = New System.Drawing.Point(176, 175)
        Me.txtCardNumber.Mask = "0000-0000-0000-0000"
        Me.txtCardNumber.Name = "txtCardNumber"
        Me.txtCardNumber.Size = New System.Drawing.Size(200, 26)
        Me.txtCardNumber.TabIndex = 4
        '
        'txtExpDate
        '
        Me.txtExpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpDate.Location = New System.Drawing.Point(176, 215)
        Me.txtExpDate.Mask = "00/00"
        Me.txtExpDate.Name = "txtExpDate"
        Me.txtExpDate.Size = New System.Drawing.Size(50, 26)
        Me.txtExpDate.TabIndex = 5
        '
        'grpStudent
        '
        Me.grpStudent.Controls.Add(Me.radNo)
        Me.grpStudent.Controls.Add(Me.radYes)
        Me.grpStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpStudent.Location = New System.Drawing.Point(16, 247)
        Me.grpStudent.Name = "grpStudent"
        Me.grpStudent.Size = New System.Drawing.Size(181, 74)
        Me.grpStudent.TabIndex = 6
        Me.grpStudent.TabStop = False
        Me.grpStudent.Text = "Are You A Student?"
        '
        'radNo
        '
        Me.radNo.AutoSize = True
        Me.radNo.Location = New System.Drawing.Point(6, 47)
        Me.radNo.Name = "radNo"
        Me.radNo.Size = New System.Drawing.Size(47, 24)
        Me.radNo.TabIndex = 1
        Me.radNo.TabStop = True
        Me.radNo.Text = "No"
        Me.radNo.UseVisualStyleBackColor = True
        '
        'radYes
        '
        Me.radYes.AutoSize = True
        Me.radYes.Location = New System.Drawing.Point(7, 26)
        Me.radYes.Name = "radYes"
        Me.radYes.Size = New System.Drawing.Size(55, 24)
        Me.radYes.TabIndex = 0
        Me.radYes.TabStop = True
        Me.radYes.Text = "Yes"
        Me.radYes.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.White
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(221, 345)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(155, 28)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "Final Total"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.White
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(402, 345)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(155, 28)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(223, 393)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(354, 20)
        Me.lblTotal.TabIndex = 10
        Me.lblTotal.Text = "Information received. Your final total is: $XXX.XX"
        Me.lblTotal.Visible = False
        '
        'lblSoftware
        '
        Me.lblSoftware.AutoSize = True
        Me.lblSoftware.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSoftware.Location = New System.Drawing.Point(398, 175)
        Me.lblSoftware.Name = "lblSoftware"
        Me.lblSoftware.Size = New System.Drawing.Size(73, 20)
        Me.lblSoftware.TabIndex = 12
        Me.lblSoftware.Text = "Software"
        '
        'chkVisio
        '
        Me.chkVisio.AutoSize = True
        Me.chkVisio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVisio.Location = New System.Drawing.Point(402, 199)
        Me.chkVisio.Name = "chkVisio"
        Me.chkVisio.Size = New System.Drawing.Size(62, 24)
        Me.chkVisio.TabIndex = 13
        Me.chkVisio.Text = "Visio"
        Me.chkVisio.UseVisualStyleBackColor = True
        '
        'chkQuickBooks
        '
        Me.chkQuickBooks.AutoSize = True
        Me.chkQuickBooks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkQuickBooks.Location = New System.Drawing.Point(402, 217)
        Me.chkQuickBooks.Name = "chkQuickBooks"
        Me.chkQuickBooks.Size = New System.Drawing.Size(113, 24)
        Me.chkQuickBooks.TabIndex = 14
        Me.chkQuickBooks.Text = "QuickBooks"
        Me.chkQuickBooks.UseVisualStyleBackColor = True
        '
        'chkProject
        '
        Me.chkProject.AutoSize = True
        Me.chkProject.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkProject.Location = New System.Drawing.Point(402, 238)
        Me.chkProject.Name = "chkProject"
        Me.chkProject.Size = New System.Drawing.Size(77, 24)
        Me.chkProject.TabIndex = 15
        Me.chkProject.Text = "Project"
        Me.chkProject.UseVisualStyleBackColor = True
        '
        'chkPowerBi
        '
        Me.chkPowerBi.AutoSize = True
        Me.chkPowerBi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPowerBi.Location = New System.Drawing.Point(402, 259)
        Me.chkPowerBi.Name = "chkPowerBi"
        Me.chkPowerBi.Size = New System.Drawing.Size(90, 24)
        Me.chkPowerBi.TabIndex = 16
        Me.chkPowerBi.Text = "Power Bi"
        Me.chkPowerBi.UseVisualStyleBackColor = True
        '
        'chkSpeedType
        '
        Me.chkSpeedType.AutoSize = True
        Me.chkSpeedType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSpeedType.Location = New System.Drawing.Point(402, 278)
        Me.chkSpeedType.Name = "chkSpeedType"
        Me.chkSpeedType.Size = New System.Drawing.Size(113, 24)
        Me.chkSpeedType.TabIndex = 17
        Me.chkSpeedType.Text = "Speed Type"
        Me.chkSpeedType.UseVisualStyleBackColor = True
        '
        'btnDailyTotal
        '
        Me.btnDailyTotal.BackColor = System.Drawing.Color.White
        Me.btnDailyTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDailyTotal.Location = New System.Drawing.Point(612, 171)
        Me.btnDailyTotal.Name = "btnDailyTotal"
        Me.btnDailyTotal.Size = New System.Drawing.Size(155, 28)
        Me.btnDailyTotal.TabIndex = 18
        Me.btnDailyTotal.Text = "Daily Total"
        Me.btnDailyTotal.UseVisualStyleBackColor = False
        '
        'lblVisio
        '
        Me.lblVisio.AutoSize = True
        Me.lblVisio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVisio.Location = New System.Drawing.Point(608, 218)
        Me.lblVisio.Name = "lblVisio"
        Me.lblVisio.Size = New System.Drawing.Size(51, 20)
        Me.lblVisio.TabIndex = 19
        Me.lblVisio.Text = "Visio: "
        Me.lblVisio.Visible = False
        '
        'lblQuickbooks
        '
        Me.lblQuickbooks.AutoSize = True
        Me.lblQuickbooks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuickbooks.Location = New System.Drawing.Point(608, 242)
        Me.lblQuickbooks.Name = "lblQuickbooks"
        Me.lblQuickbooks.Size = New System.Drawing.Size(100, 20)
        Me.lblQuickbooks.TabIndex = 20
        Me.lblQuickbooks.Text = "Quickbooks: "
        Me.lblQuickbooks.Visible = False
        '
        'lblProject
        '
        Me.lblProject.AutoSize = True
        Me.lblProject.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProject.Location = New System.Drawing.Point(608, 263)
        Me.lblProject.Name = "lblProject"
        Me.lblProject.Size = New System.Drawing.Size(62, 20)
        Me.lblProject.TabIndex = 21
        Me.lblProject.Text = "Project:"
        Me.lblProject.Visible = False
        '
        'lblPowerBi
        '
        Me.lblPowerBi.AutoSize = True
        Me.lblPowerBi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPowerBi.Location = New System.Drawing.Point(608, 283)
        Me.lblPowerBi.Name = "lblPowerBi"
        Me.lblPowerBi.Size = New System.Drawing.Size(75, 20)
        Me.lblPowerBi.TabIndex = 22
        Me.lblPowerBi.Text = "Power Bi:"
        Me.lblPowerBi.Visible = False
        '
        'lblSpeedType
        '
        Me.lblSpeedType.AutoSize = True
        Me.lblSpeedType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpeedType.Location = New System.Drawing.Point(608, 303)
        Me.lblSpeedType.Name = "lblSpeedType"
        Me.lblSpeedType.Size = New System.Drawing.Size(98, 20)
        Me.lblSpeedType.TabIndex = 23
        Me.lblSpeedType.Text = "Speed Type:"
        Me.lblSpeedType.Visible = False
        '
        'frmBookstore
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblSpeedType)
        Me.Controls.Add(Me.lblPowerBi)
        Me.Controls.Add(Me.lblProject)
        Me.Controls.Add(Me.lblQuickbooks)
        Me.Controls.Add(Me.lblVisio)
        Me.Controls.Add(Me.btnDailyTotal)
        Me.Controls.Add(Me.chkSpeedType)
        Me.Controls.Add(Me.chkPowerBi)
        Me.Controls.Add(Me.chkProject)
        Me.Controls.Add(Me.chkQuickBooks)
        Me.Controls.Add(Me.chkVisio)
        Me.Controls.Add(Me.lblSoftware)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.grpStudent)
        Me.Controls.Add(Me.txtExpDate)
        Me.Controls.Add(Me.txtCardNumber)
        Me.Controls.Add(Me.lblExpiration)
        Me.Controls.Add(Me.lblCreditCard)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.picBookstore)
        Me.Name = "frmBookstore"
        Me.Text = "College Bookstore Access Codes"
        CType(Me.picBookstore, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpStudent.ResumeLayout(False)
        Me.grpStudent.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBookstore As PictureBox
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblCreditCard As Label
    Friend WithEvents lblExpiration As Label
    Friend WithEvents txtCardNumber As MaskedTextBox
    Friend WithEvents txtExpDate As MaskedTextBox
    Friend WithEvents grpStudent As GroupBox
    Friend WithEvents radNo As RadioButton
    Friend WithEvents radYes As RadioButton
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblSoftware As Label
    Friend WithEvents chkVisio As CheckBox
    Friend WithEvents chkQuickBooks As CheckBox
    Friend WithEvents chkProject As CheckBox
    Friend WithEvents chkPowerBi As CheckBox
    Friend WithEvents chkSpeedType As CheckBox
    Friend WithEvents btnDailyTotal As Button
    Friend WithEvents lblVisio As Label
    Friend WithEvents lblQuickbooks As Label
    Friend WithEvents lblProject As Label
    Friend WithEvents lblPowerBi As Label
    Friend WithEvents lblSpeedType As Label
End Class
