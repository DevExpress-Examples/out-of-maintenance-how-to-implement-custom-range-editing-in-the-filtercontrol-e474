Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication197
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.filterControl1 = New DevExpress.XtraEditors.FilterControl()
			Me.popupContainerControl1 = New DevExpress.XtraEditors.PopupContainerControl()
			Me.comboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.dateEdit1 = New DevExpress.XtraEditors.DateEdit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.popupContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.popupContainerControl1.SuspendLayout()
			CType(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.EmbeddedNavigator.Name = ""
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(658, 289)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.simpleButton1)
			Me.panelControl1.Controls.Add(Me.filterControl1)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.panelControl1.Location = New System.Drawing.Point(0, 289)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(658, 147)
			Me.panelControl1.TabIndex = 1
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(571, 5)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton1.TabIndex = 1
			Me.simpleButton1.Text = "Apply"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' filterControl1
			' 
			Me.filterControl1.Dock = System.Windows.Forms.DockStyle.Left
			Me.filterControl1.Location = New System.Drawing.Point(2, 2)
			Me.filterControl1.Name = "filterControl1"
			Me.filterControl1.Size = New System.Drawing.Size(563, 143)
			Me.filterControl1.TabIndex = 0
			Me.filterControl1.Text = "filterControl1"
			' 
			' popupContainerControl1
			' 
			Me.popupContainerControl1.Controls.Add(Me.comboBoxEdit1)
			Me.popupContainerControl1.Controls.Add(Me.dateEdit1)
			Me.popupContainerControl1.Location = New System.Drawing.Point(247, 124)
			Me.popupContainerControl1.Name = "popupContainerControl1"
			Me.popupContainerControl1.Size = New System.Drawing.Size(200, 45)
			Me.popupContainerControl1.TabIndex = 2
			' 
			' comboBoxEdit1
			' 
			Me.comboBoxEdit1.Dock = System.Windows.Forms.DockStyle.Top
			Me.comboBoxEdit1.EditValue = "Day"
			Me.comboBoxEdit1.Location = New System.Drawing.Point(0, 20)
			Me.comboBoxEdit1.Name = "comboBoxEdit1"
			Me.comboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEdit1.Properties.Items.AddRange(New Object() { "Day", "Week", "Month"})
			Me.comboBoxEdit1.Size = New System.Drawing.Size(200, 20)
			Me.comboBoxEdit1.TabIndex = 1
			' 
			' dateEdit1
			' 
			Me.dateEdit1.Dock = System.Windows.Forms.DockStyle.Top
			Me.dateEdit1.EditValue = Nothing
			Me.dateEdit1.Location = New System.Drawing.Point(0, 0)
			Me.dateEdit1.Name = "dateEdit1"
			Me.dateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.dateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.dateEdit1.Size = New System.Drawing.Size(200, 20)
			Me.dateEdit1.TabIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(658, 436)
			Me.Controls.Add(Me.popupContainerControl1)
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.popupContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.popupContainerControl1.ResumeLayout(False)
			CType(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private filterControl1 As DevExpress.XtraEditors.FilterControl
		Private popupContainerControl1 As DevExpress.XtraEditors.PopupContainerControl
		Private comboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
		Private dateEdit1 As DevExpress.XtraEditors.DateEdit
	End Class
End Namespace

