<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim IdMarcaLabel As System.Windows.Forms.Label
        Dim MatriculaLabel As System.Windows.Forms.Label
        Dim ModeloLabel As System.Windows.Forms.Label
        Dim AnoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.botSair = New System.Windows.Forms.Button()
        Me.botFechar = New System.Windows.Forms.Button()
        Me.botRemover = New System.Windows.Forms.Button()
        Me.botGravar = New System.Windows.Forms.Button()
        Me.botNovo = New System.Windows.Forms.Button()
        Me.botSeguinte = New System.Windows.Forms.Button()
        Me.botAnterior = New System.Windows.Forms.Button()
        Me.CARROSBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CARROSBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BDDataSet = New GestaoBD.BDDataSet()
        Me.CARROSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CARROSTableAdapter = New GestaoBD.BDDataSetTableAdapters.CARROSTableAdapter()
        Me.TableAdapterManager = New GestaoBD.BDDataSetTableAdapters.TableAdapterManager()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.IdMarcaTextBox = New System.Windows.Forms.TextBox()
        Me.MatriculaTextBox = New System.Windows.Forms.TextBox()
        Me.ModeloTextBox = New System.Windows.Forms.TextBox()
        Me.AnoTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label1 = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        IdMarcaLabel = New System.Windows.Forms.Label()
        MatriculaLabel = New System.Windows.Forms.Label()
        ModeloLabel = New System.Windows.Forms.Label()
        AnoLabel = New System.Windows.Forms.Label()
        CType(Me.CARROSBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CARROSBindingNavigator.SuspendLayout()
        CType(Me.BDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CARROSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(300, 166)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 48
        IDLabel.Text = "ID:"
        '
        'IdMarcaLabel
        '
        IdMarcaLabel.AutoSize = True
        IdMarcaLabel.Location = New System.Drawing.Point(300, 192)
        IdMarcaLabel.Name = "IdMarcaLabel"
        IdMarcaLabel.Size = New System.Drawing.Size(51, 13)
        IdMarcaLabel.TabIndex = 50
        IdMarcaLabel.Text = "id Marca:"
        '
        'MatriculaLabel
        '
        MatriculaLabel.AutoSize = True
        MatriculaLabel.Location = New System.Drawing.Point(300, 218)
        MatriculaLabel.Name = "MatriculaLabel"
        MatriculaLabel.Size = New System.Drawing.Size(52, 13)
        MatriculaLabel.TabIndex = 52
        MatriculaLabel.Text = "matricula:"
        '
        'ModeloLabel
        '
        ModeloLabel.AutoSize = True
        ModeloLabel.Location = New System.Drawing.Point(300, 244)
        ModeloLabel.Name = "ModeloLabel"
        ModeloLabel.Size = New System.Drawing.Size(44, 13)
        ModeloLabel.TabIndex = 54
        ModeloLabel.Text = "modelo:"
        '
        'AnoLabel
        '
        AnoLabel.AutoSize = True
        AnoLabel.Location = New System.Drawing.Point(300, 270)
        AnoLabel.Name = "AnoLabel"
        AnoLabel.Size = New System.Drawing.Size(28, 13)
        AnoLabel.TabIndex = 56
        AnoLabel.Text = "ano:"
        '
        'botSair
        '
        Me.botSair.Location = New System.Drawing.Point(697, 381)
        Me.botSair.Name = "botSair"
        Me.botSair.Size = New System.Drawing.Size(91, 35)
        Me.botSair.TabIndex = 48
        Me.botSair.Text = "Sair"
        Me.botSair.UseVisualStyleBackColor = True
        '
        'botFechar
        '
        Me.botFechar.Location = New System.Drawing.Point(586, 381)
        Me.botFechar.Name = "botFechar"
        Me.botFechar.Size = New System.Drawing.Size(91, 35)
        Me.botFechar.TabIndex = 47
        Me.botFechar.Text = "Fechar"
        Me.botFechar.UseVisualStyleBackColor = True
        '
        'botRemover
        '
        Me.botRemover.Location = New System.Drawing.Point(474, 381)
        Me.botRemover.Name = "botRemover"
        Me.botRemover.Size = New System.Drawing.Size(91, 35)
        Me.botRemover.TabIndex = 46
        Me.botRemover.Text = "Remover"
        Me.botRemover.UseVisualStyleBackColor = True
        '
        'botGravar
        '
        Me.botGravar.Location = New System.Drawing.Point(367, 381)
        Me.botGravar.Name = "botGravar"
        Me.botGravar.Size = New System.Drawing.Size(91, 35)
        Me.botGravar.TabIndex = 45
        Me.botGravar.Text = "Gravar"
        Me.botGravar.UseVisualStyleBackColor = True
        '
        'botNovo
        '
        Me.botNovo.Location = New System.Drawing.Point(260, 381)
        Me.botNovo.Name = "botNovo"
        Me.botNovo.Size = New System.Drawing.Size(91, 35)
        Me.botNovo.TabIndex = 44
        Me.botNovo.Text = "Novo"
        Me.botNovo.UseVisualStyleBackColor = True
        '
        'botSeguinte
        '
        Me.botSeguinte.Location = New System.Drawing.Point(145, 381)
        Me.botSeguinte.Name = "botSeguinte"
        Me.botSeguinte.Size = New System.Drawing.Size(91, 35)
        Me.botSeguinte.TabIndex = 43
        Me.botSeguinte.Text = "Seguinte"
        Me.botSeguinte.UseVisualStyleBackColor = True
        '
        'botAnterior
        '
        Me.botAnterior.Location = New System.Drawing.Point(28, 381)
        Me.botAnterior.Name = "botAnterior"
        Me.botAnterior.Size = New System.Drawing.Size(91, 35)
        Me.botAnterior.TabIndex = 42
        Me.botAnterior.Text = "Anterior"
        Me.botAnterior.UseVisualStyleBackColor = True
        '
        'CARROSBindingNavigator
        '
        Me.CARROSBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CARROSBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CARROSBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CARROSBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CARROSBindingNavigatorSaveItem})
        Me.CARROSBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CARROSBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CARROSBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CARROSBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CARROSBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CARROSBindingNavigator.Name = "CARROSBindingNavigator"
        Me.CARROSBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CARROSBindingNavigator.Size = New System.Drawing.Size(808, 25)
        Me.CARROSBindingNavigator.TabIndex = 29
        Me.CARROSBindingNavigator.Text = "BindingNavigator1"
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
        'CARROSBindingNavigatorSaveItem
        '
        Me.CARROSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CARROSBindingNavigatorSaveItem.Image = CType(resources.GetObject("CARROSBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CARROSBindingNavigatorSaveItem.Name = "CARROSBindingNavigatorSaveItem"
        Me.CARROSBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CARROSBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'BDDataSet
        '
        Me.BDDataSet.DataSetName = "BDDataSet"
        Me.BDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CARROSBindingSource
        '
        Me.CARROSBindingSource.DataMember = "CARROS"
        Me.CARROSBindingSource.DataSource = Me.BDDataSet
        '
        'CARROSTableAdapter
        '
        Me.CARROSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CARROSTableAdapter = Me.CARROSTableAdapter
        Me.TableAdapterManager.MARCASTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = GestaoBD.BDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CARROSBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(358, 163)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 49
        '
        'IdMarcaTextBox
        '
        Me.IdMarcaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CARROSBindingSource, "idMarca", True))
        Me.IdMarcaTextBox.Location = New System.Drawing.Point(358, 189)
        Me.IdMarcaTextBox.Name = "IdMarcaTextBox"
        Me.IdMarcaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdMarcaTextBox.TabIndex = 51
        '
        'MatriculaTextBox
        '
        Me.MatriculaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CARROSBindingSource, "matricula", True))
        Me.MatriculaTextBox.Location = New System.Drawing.Point(358, 215)
        Me.MatriculaTextBox.Name = "MatriculaTextBox"
        Me.MatriculaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MatriculaTextBox.TabIndex = 53
        '
        'ModeloTextBox
        '
        Me.ModeloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CARROSBindingSource, "modelo", True))
        Me.ModeloTextBox.Location = New System.Drawing.Point(358, 241)
        Me.ModeloTextBox.Name = "ModeloTextBox"
        Me.ModeloTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ModeloTextBox.TabIndex = 55
        '
        'AnoTextBox
        '
        Me.AnoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CARROSBindingSource, "ano", True))
        Me.AnoTextBox.Location = New System.Drawing.Point(358, 267)
        Me.AnoTextBox.Name = "AnoTextBox"
        Me.AnoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AnoTextBox.TabIndex = 57
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Tan
        Me.GroupBox1.Location = New System.Drawing.Point(266, 138)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(227, 166)
        Me.GroupBox1.TabIndex = 58
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Carros"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(336, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 25)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Carros"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(IdMarcaLabel)
        Me.Controls.Add(Me.IdMarcaTextBox)
        Me.Controls.Add(MatriculaLabel)
        Me.Controls.Add(Me.MatriculaTextBox)
        Me.Controls.Add(ModeloLabel)
        Me.Controls.Add(Me.ModeloTextBox)
        Me.Controls.Add(AnoLabel)
        Me.Controls.Add(Me.AnoTextBox)
        Me.Controls.Add(Me.botSair)
        Me.Controls.Add(Me.botFechar)
        Me.Controls.Add(Me.botRemover)
        Me.Controls.Add(Me.botGravar)
        Me.Controls.Add(Me.botNovo)
        Me.Controls.Add(Me.botSeguinte)
        Me.Controls.Add(Me.botAnterior)
        Me.Controls.Add(Me.CARROSBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.CARROSBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CARROSBindingNavigator.ResumeLayout(False)
        Me.CARROSBindingNavigator.PerformLayout()
        CType(Me.BDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CARROSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents CARROSBindingNavigator As BindingNavigator
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
    Friend WithEvents CARROSBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents BDDataSet As BDDataSet
    Friend WithEvents CARROSBindingSource As BindingSource
    Friend WithEvents CARROSTableAdapter As BDDataSetTableAdapters.CARROSTableAdapter
    Friend WithEvents TableAdapterManager As BDDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents IdMarcaTextBox As TextBox
    Friend WithEvents MatriculaTextBox As TextBox
    Friend WithEvents ModeloTextBox As TextBox
    Friend WithEvents AnoTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As Label
End Class
