<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IDLabel As System.Windows.Forms.Label
        Dim MarcaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.botSair = New System.Windows.Forms.Button()
        Me.botFechar = New System.Windows.Forms.Button()
        Me.botRemover = New System.Windows.Forms.Button()
        Me.botGravar = New System.Windows.Forms.Button()
        Me.botNovo = New System.Windows.Forms.Button()
        Me.botSeguinte = New System.Windows.Forms.Button()
        Me.botAnterior = New System.Windows.Forms.Button()
        Me.MARCASBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MARCASBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.MARCASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDDataSet = New GestaoBD.BDDataSet()
        Me.MarcaTextBox = New System.Windows.Forms.TextBox()
        Me.MARCASTableAdapter = New GestaoBD.BDDataSetTableAdapters.MARCASTableAdapter()
        Me.TableAdapterManager = New GestaoBD.BDDataSetTableAdapters.TableAdapterManager()
        IDLabel = New System.Windows.Forms.Label()
        MarcaLabel = New System.Windows.Forms.Label()
        CType(Me.MARCASBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MARCASBindingNavigator.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MARCASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(28, 42)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 0
        IDLabel.Text = "ID:"
        '
        'MarcaLabel
        '
        MarcaLabel.AutoSize = True
        MarcaLabel.Location = New System.Drawing.Point(28, 68)
        MarcaLabel.Name = "MarcaLabel"
        MarcaLabel.Size = New System.Drawing.Size(39, 13)
        MarcaLabel.TabIndex = 2
        MarcaLabel.Text = "marca:"
        '
        'botSair
        '
        Me.botSair.Location = New System.Drawing.Point(690, 369)
        Me.botSair.Name = "botSair"
        Me.botSair.Size = New System.Drawing.Size(91, 35)
        Me.botSair.TabIndex = 66
        Me.botSair.Text = "Sair"
        Me.botSair.UseVisualStyleBackColor = True
        '
        'botFechar
        '
        Me.botFechar.Location = New System.Drawing.Point(579, 369)
        Me.botFechar.Name = "botFechar"
        Me.botFechar.Size = New System.Drawing.Size(91, 35)
        Me.botFechar.TabIndex = 65
        Me.botFechar.Text = "Fechar"
        Me.botFechar.UseVisualStyleBackColor = True
        '
        'botRemover
        '
        Me.botRemover.Location = New System.Drawing.Point(467, 369)
        Me.botRemover.Name = "botRemover"
        Me.botRemover.Size = New System.Drawing.Size(91, 35)
        Me.botRemover.TabIndex = 64
        Me.botRemover.Text = "Remover"
        Me.botRemover.UseVisualStyleBackColor = True
        '
        'botGravar
        '
        Me.botGravar.Location = New System.Drawing.Point(360, 369)
        Me.botGravar.Name = "botGravar"
        Me.botGravar.Size = New System.Drawing.Size(91, 35)
        Me.botGravar.TabIndex = 63
        Me.botGravar.Text = "Gravar"
        Me.botGravar.UseVisualStyleBackColor = True
        '
        'botNovo
        '
        Me.botNovo.Location = New System.Drawing.Point(253, 369)
        Me.botNovo.Name = "botNovo"
        Me.botNovo.Size = New System.Drawing.Size(91, 35)
        Me.botNovo.TabIndex = 62
        Me.botNovo.Text = "Novo"
        Me.botNovo.UseVisualStyleBackColor = True
        '
        'botSeguinte
        '
        Me.botSeguinte.Location = New System.Drawing.Point(138, 369)
        Me.botSeguinte.Name = "botSeguinte"
        Me.botSeguinte.Size = New System.Drawing.Size(91, 35)
        Me.botSeguinte.TabIndex = 61
        Me.botSeguinte.Text = "Seguinte"
        Me.botSeguinte.UseVisualStyleBackColor = True
        '
        'botAnterior
        '
        Me.botAnterior.Location = New System.Drawing.Point(21, 369)
        Me.botAnterior.Name = "botAnterior"
        Me.botAnterior.Size = New System.Drawing.Size(91, 35)
        Me.botAnterior.TabIndex = 60
        Me.botAnterior.Text = "Anterior"
        Me.botAnterior.UseVisualStyleBackColor = True
        '
        'MARCASBindingNavigator
        '
        Me.MARCASBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MARCASBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MARCASBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MARCASBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MARCASBindingNavigatorSaveItem})
        Me.MARCASBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MARCASBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MARCASBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MARCASBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MARCASBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MARCASBindingNavigator.Name = "MARCASBindingNavigator"
        Me.MARCASBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MARCASBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.MARCASBindingNavigator.TabIndex = 59
        Me.MARCASBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Adicionar novo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de itens"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primeiro"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posição"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posição actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover seguinte"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'MARCASBindingNavigatorSaveItem
        '
        Me.MARCASBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MARCASBindingNavigatorSaveItem.Image = CType(resources.GetObject("MARCASBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MARCASBindingNavigatorSaveItem.Name = "MARCASBindingNavigatorSaveItem"
        Me.MARCASBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MARCASBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Tan
        Me.GroupBox1.Controls.Add(IDLabel)
        Me.GroupBox1.Controls.Add(Me.IDTextBox)
        Me.GroupBox1.Controls.Add(MarcaLabel)
        Me.GroupBox1.Controls.Add(Me.MarcaTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(266, 155)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(234, 122)
        Me.GroupBox1.TabIndex = 67
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Marcas"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MARCASBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(73, 39)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 1
        '
        'MARCASBindingSource
        '
        Me.MARCASBindingSource.DataMember = "MARCAS"
        Me.MARCASBindingSource.DataSource = Me.BDDataSet
        '
        'BDDataSet
        '
        Me.BDDataSet.DataSetName = "BDDataSet"
        Me.BDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MarcaTextBox
        '
        Me.MarcaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MARCASBindingSource, "marca", True))
        Me.MarcaTextBox.Location = New System.Drawing.Point(73, 65)
        Me.MarcaTextBox.Name = "MarcaTextBox"
        Me.MarcaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MarcaTextBox.TabIndex = 3
        '
        'MARCASTableAdapter
        '
        Me.MARCASTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CARROSTableAdapter = Nothing
        Me.TableAdapterManager.MARCASTableAdapter = Me.MARCASTableAdapter
        Me.TableAdapterManager.UpdateOrder = GestaoBD.BDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.botSair)
        Me.Controls.Add(Me.botFechar)
        Me.Controls.Add(Me.botRemover)
        Me.Controls.Add(Me.botGravar)
        Me.Controls.Add(Me.botNovo)
        Me.Controls.Add(Me.botSeguinte)
        Me.Controls.Add(Me.botAnterior)
        Me.Controls.Add(Me.MARCASBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.MARCASBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MARCASBindingNavigator.ResumeLayout(False)
        Me.MARCASBindingNavigator.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.MARCASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents botSair As Button
    Friend WithEvents botFechar As Button
    Friend WithEvents botRemover As Button
    Friend WithEvents botGravar As Button
    Friend WithEvents botNovo As Button
    Friend WithEvents botSeguinte As Button
    Friend WithEvents botAnterior As Button
    Friend WithEvents MARCASBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents MARCASBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BDDataSet As BDDataSet
    Friend WithEvents MARCASBindingSource As BindingSource
    Friend WithEvents MARCASTableAdapter As BDDataSetTableAdapters.MARCASTableAdapter
    Friend WithEvents TableAdapterManager As BDDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents MarcaTextBox As TextBox
End Class
