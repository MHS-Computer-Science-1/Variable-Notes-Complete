Public Class Form1




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Input Step 

        'Variables are used by apps to hold information
        'Think of variables like little containers
        'The value of variables can change over time

        'Create variables for the length and width
        Dim length As Double
        Dim width As Double

        'Dim (dimension) is what creates a variable
        'length and width are the names I have chosen for my variables

        'Legal identifiers for variables
        '1. Letters, numbers, NO SPACES 
        '2. Can't start with number
        '3. Can't be a reserved word

        'Other types of variables
        '1. Integer (pos/neg whole number)
        '2. Double (contain a decimal point)
        '3. String (text)

        'Input from the textboxes
        length = TextBox1.Text
        width = TextBox2.Text


        'Compute Area
        Dim area As Double
        area = length * width
        'Math Operations: +, -, *, /, ^, ()

        'Output step
        Label4.Text = area

    End Sub
End Class
