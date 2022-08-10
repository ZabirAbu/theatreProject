Module InputMod
    Structure users
        <VBFixedString(6)> Public username As String '2 bytes per character
        <VBFixedString(6)> Public password As String

        Dim code As Integer
    End Structure

    Public staff As users

    Public Members As Memberships

    Structure Memberships
        Public MemberID As String
        <VBFixedString(6)> Public Category As String  '2 bytes per character
        <VBFixedString(10)> Public Surname As String
        <VBFixedString(10)> Public Firstname As String
    End Structure

    Structure ProductType 'this is the structure format for a record
        Dim ProductID As Short
        <VBFixedString(18)> Public Description As String 'VBFixedString used to know how big the size of a record will be because the size of other data types are fixed
        Dim Price As Decimal
        Dim QuantityInStock As Short
        Dim ReorderLevel As Short
    End Structure
    Public Products As ProductType 'record Products created, made Public so it can be shared anywhere in the system

    Structure Customerdetails
        <VBFixedString(9)> Public CustomerID As String
        <VBFixedString(10)> Public Firstname As String
        <VBFixedString(24)> Public Lastname As String 'long size
        <VBFixedString(40)> Public Addressslineone As String
        <VBFixedString(40)> Public Addressslinetwo As String
        <VBFixedString(7)> Public Postcode As String
    End Structure
    Public customers As Customerdetails


    Structure ShowType
        Public ShowId As Integer
        <VBFixedString(20)> Public ShowName As String
        <VBFixedString(10)> Public ShowDate As String
        <VBFixedString(4)> Public ShowTime As String
        Public Seats1 As Boolean
        Public Seats2 As Boolean
        Public Seats3 As Boolean
        Public Seats4 As Boolean
        Public Seats5 As Boolean
        Public Seats6 As Boolean
        Public Seats7 As Boolean
        Public Seats8 As Boolean
        Public Seats9 As Boolean
        Public Seats10 As Boolean
    End Structure
    Structure BookingType
        Public SeatNo1 As Integer
        Public SeatNo2 As Integer
        Public SeatNo3 As Integer
        Public SeatNo4 As Integer
        Public SeatNo5 As Integer
        Public SeatNo6 As Integer
        Public SeatNo7 As Integer
        Public SeatNo8 As Integer
        Public SeatNo9 As Integer
        Public SeatNo10 As Integer
        <VBFixedString(20)> Public CustomerName As String
        <VBFixedString(9)> Public CustomerID As String
        <VBFixedString(20)> Public ShowName As String
        <VBFixedString(10)> Public ShowDate As String
        <VBFixedString(4)> Public ShowTime As String
    End Structure

    Public FileNo As Integer
    Public NewBooking As BookingType

End Module