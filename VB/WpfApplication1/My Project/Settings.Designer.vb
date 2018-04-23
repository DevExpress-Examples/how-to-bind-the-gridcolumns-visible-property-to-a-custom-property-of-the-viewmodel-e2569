﻿' Developer Express Code Central Example:
' How to bind the GridColumn Visible property to the dependency property of the ViewModel
' 
' In the v9.3 version, GridColumn properties are not inherited from the
' FrameworkElement class. GridColumn property binding can be done only using the
' BindingOperations.SetBinding method via code. In the v10.1 version, we have
' overcome this issue. You can bind any GridColumn property via xaml.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E2569

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.1
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Namespace My


    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")> _
    Friend NotInheritable Partial Class Settings
        Inherits System.Configuration.ApplicationSettingsBase

        Private Shared defaultInstance As Settings = (CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New Settings()), Settings))

        Public Shared ReadOnly Property [Default]() As Settings
            Get
                Return defaultInstance
            End Get
        End Property
    End Class
End Namespace