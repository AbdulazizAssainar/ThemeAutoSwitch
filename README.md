# DataGridView and Form Theme Switcher

This project demonstrates how to dynamically switch between light and dark themes for a DataGridView and a Form in a Windows Forms application using C#.

## Features

- Switch between light and dark themes.
- Consistent theme application across the Form and DataGridView.
- Enhanced readability with distinct color settings for the Form and DataGridView.
- Customizable settings for fonts, colors, padding, and borders.

## Implementation

### DataGridViewCellStyle.cs

This class contains methods to apply light and dark themes to both DataGridView and Form controls.

#### Methods

- `ApplyLightTheme(DataGridView dataGridView)`: Applies light theme settings to a DataGridView.
- `ApplyDarkTheme(DataGridView dataGridView)`: Applies dark theme settings to a DataGridView.
- `ApplyLightTheme(Form form)`: Applies light theme settings to a Form.
- `ApplyDarkTheme(Form form)`: Applies dark theme settings to a Form.
- `UpdateTheme(Form form, bool isLightTheme)`: Updates the theme of the form and all its controls based on the provided theme (light or dark).

### Usage

1. **Integration**: Add the DataGridViewCellStyle.cs file to your Windows Forms project.

2. **Implement Theme Switching Logic**: In your form where you want to apply the theme switching functionality, you'll typically have a button or some other trigger to switch between the light and dark themes. Here's an example implementation:

   ```csharp
   using System;
   using System.Windows.Forms;

   namespace YourNamespace
   {
       public partial class YourForm : Form
       {
           private bool isLightTheme = true;

           public YourForm()
           {
               InitializeComponent();
           }

           private void YourForm_Load(object sender, EventArgs e)
           {
               // Apply the initial theme when the form loads
               UpdateTheme();
           }

           private void ToggleThemeButton_Click(object sender, EventArgs e)
           {
               // Toggle between light and dark themes
               isLightTheme = !isLightTheme;
               UpdateTheme();
           }

           private void UpdateTheme()
           {
               // Update the theme of the form and its controls
               DataGridViewCellStyle.UpdateTheme(this, isLightTheme);
           }
       }
   }
   ```

   In this example, YourForm_Load applies the initial theme when the form loads, and ToggleThemeButton_Click toggles between the light and dark themes when a button (named ToggleThemeButton here) is clicked.

3. **Run Your Application**: Build and run your Windows Forms application. You should be able to switch between the light and dark themes by interacting with the designated trigger (e.g., a button).

By following these steps, you can easily integrate and use the dynamic theme switching functionality in your Windows Forms application.