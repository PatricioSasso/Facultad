Imports System.Drawing
Public Class Form1
    'Creación de los Astros que intervienene en el sistema solar
    Dim Sol As New Astro(60, 60, "Sol")
    Dim Mercurio As New Astro(30, 30, "Mercurio")
    Dim Venus As New Astro(30, 30, "Venus")
    Dim Tierra As New Astro(30, 30, "Tierra")
    Dim Marte As New Astro(40, 40, "Marte")
    Dim Jupiter As New Astro(45, 45, "Jupiter")
    Dim Saturno As New Astro(55, 55, "Saturno")
    Dim Urano As New Astro(30, 30, "Urano")
    Dim Neptuno As New Astro(30, 30, "Neptuno")
    Dim Pluton As New Astro(30, 30, "Pluton")
    'Vector que contiene todos los Astros
    Dim VectorAstro() As Astro = {Mercurio, Venus, Tierra, Marte, Jupiter, Saturno, Urano, Neptuno, Pluton}
    'Vector con los radios de los Astros
    Dim VectorRadios() As Integer = {60, 100, 150, 200, 250, 300, 350, 400, 450}
    'Creación de una Grilla
    Dim WithEvents Grilla As New DataGridView
    'Vectores para las columna de la Grilla
    Dim DatosGrillaTituloColumna() = {"Planetas", "X", "Y"}
    Dim DatosGrillaAnchoColumna() = {60, 40, 40}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Se agregan los Astros y la grilla a la colección de controles del formulario
        Me.Controls.Add(Sol)
        Me.Controls.AddRange(VectorAstro)
        Me.Controls.Add(Grilla)
        'Se configura la grilla
        Grilla.Name = "Grilla"
        Grilla.RowHeadersVisible = False
        Grilla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Grilla.AllowUserToAddRows = False
        Grilla.AllowUserToDeleteRows = False
        Grilla.AllowUserToResizeColumns = False
        Grilla.AllowUserToResizeRows = False
        Grilla.ScrollBars = False
        Grilla.EditMode = DataGridViewEditMode.EditProgrammatically
        Grilla.Enabled = False
        Grilla.Width = 143
        Grilla.Location = New Point(0, 0)
        'Se crean las columnas, se configuran y se le coloca la leyenda al header de columnas
        For c = 0 To 2
            Dim celda As DataGridViewCell = New DataGridViewTextBoxCell
            Dim columna As New DataGridViewColumn(celda)
            columna.Resizable = DataGridViewTriState.False
            columna.Width = DatosGrillaAnchoColumna(c)
            Grilla.Columns.Add(columna)
            Grilla.Columns(c).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Grilla.Columns(c).HeaderText = DatosGrillaTituloColumna(c)
        Next
        'Se agregan filas (una por cada astro)
        Grilla.Rows.Add(VectorAstro.Count)
        'Se configura el alto de la grilla en función a la cantidad de filas y el alto de cada una más un offset de 4
        Grilla.Height = (Grilla.Rows.Count * (Grilla.Rows(0).Height + 2)) + 4
        'Se carga la imagen del sol desde los recursos
        Sol.BMP = SistemaSolar.My.Resources.ResourceManager.GetObject("Sol")
        'Se centra el Sol
        Sol.Location = _
            New Point((Me.Width / 2) - Me.Sol.Width / 2, _
                      (Me.Height / 2) - Me.Sol.Height / 2)

        ' Se recorre el vector de Astros
        For A = 0 To VectorAstro.Count - 1
            'A la fila agregada le coloco el nombre del Astro
            Grilla.Rows(A).Cells(0).Value = VectorAstro(A).Name
            'Configuro los BMP
            VectorAstro(A).BMP = SistemaSolar.My.Resources.ResourceManager.GetObject(VectorAstro(A).Name)
            'Ubica cada astro en su posición inicial
            VectorAstro(A).Location = _
                         New Point(((Me.Width / 2) - VectorAstro(A).Width / 2) + VectorRadios(A), _
                              (Me.Height / 2) - VectorAstro(A).Height / 2)
        Next
    End Sub

    Dim Vvalores() As Decimal = MovimientoPlaneta.RetornaGrados
    Dim Contador As Double = 0

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        For C = 0 To 8
            VectorAstro(C).Location = Polares.XY(VectorRadios(C), Contador * Vvalores(C), _
                                (Me.Width / 2) - (VectorAstro(C).Width / 2), _
                                (Me.Height / 2) - (VectorAstro(C).Height / 2))

            Me.Grilla.Rows(C).Cells(1).Value = VectorAstro(C).Location.X
            Me.Grilla.Rows(C).Cells(2).Value = VectorAstro(C).Location.Y
           
        Next
        Contador += 1
        ' Para evitar el desbordamiento del Double
        If Contador >= 10000000 Then
            Me.Timer1.Enabled = False
            If MessageBox.Show("¿Desea Reiniciar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Contador = 1
                Me.Timer1.Enabled = True
            Else
                End
            End If
        End If


    End Sub


    Private Sub Grilla_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla.CellEnter
        Grilla.CurrentCell.Style.SelectionBackColor = Color.White
        Grilla.CurrentCell.Style.SelectionForeColor = Color.Black
    End Sub
End Class
Public Class Astro
    Inherits PictureBox
    ' Private Vruta As Bitmap
    Public Property BMP() As Bitmap
        Get
            Return Me.Image
        End Get
        Set(ByVal value As Bitmap)
            ' Vruta = value
            Me.Image = value
        End Set
    End Property
   
    Sub New()
        Me.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BackColor = System.Drawing.Color.Transparent
    End Sub
    Sub New(pX As Integer, pY As Integer, pNombre As String)
        Me.New()
        Me.Size = New Point(pX, pY)
        Me.Name = pNombre
    End Sub




End Class
Public Class Polares
    Public Shared Function XY(pRadio As Decimal, pGrados As Decimal, _
                              pOffsetX As Decimal, pOffsetY As Decimal) As Point
        Return New Point( _
        (pRadio * Math.Cos(pGrados * Math.PI / 180)) + pOffsetX, _
        (pRadio * Math.Sin(pGrados * Math.PI / 180)) + pOffsetY)
    End Function
End Class
Public Class MovimientoPlaneta
    ' Mercurio,Venus,Tierra,Marte,Jupiter,Saturno,Urano,Neptuno,Pluton
    Shared Vdias() As Decimal = {88, 225, 365, 687, 4015, 10585, 30660, 59860, 90520}
    Shared Vgrados(8) As Decimal
    Sub New()

    End Sub
    Public Shared Function RetornaGrados() As Array
        For C = 0 To 8
            Vgrados(C) = Vdias(0) / Vdias(C)
        Next
        Return Vgrados
    End Function
End Class
