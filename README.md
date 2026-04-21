# ASP.NET CORE DataGrid - Editing Focus Clicked Cell

This repository contains an ASP.NET Core sample that demonstrates how to focus the clicked cell during normal editing in a Syncfusion ASP.NET Core DataGrid.

## Project Overview

This sample explains how to maintain focus on the selected cell when editing is initiated in an ASP.NET Core DataGrid. By default, certain edit actions can shift focus away from the clicked cell, which may affect usability and keyboard navigation. To resolve this behavior, the implementation uses JavaScript’s `focus` method within the DataGrid `actionComplete` event so that the clicked cell remains active after editing operations complete.

The project is intended as a focused reference for developers who want to control editing focus behavior by combining ASP.NET Core DataGrid configuration with client-side scripting.

## Key Features

- Normal editing behavior in Syncfusion ASP.NET Core DataGrid
- Retains focus on the clicked cell after edit actions
- Demonstrates integration of JavaScript with DataGrid events

## Prerequisites

- Visual Studio 2022
- ASP.NET Core compatible .NET SDK

## Running the Application

Follow the steps below to clone the repository, restore dependencies, and run the application.

1. Clone the repository and navigate to the project directory:

   ```bash
   git clone https://github.com/SyncfusionExamples/EJ2-DataGrid-Core-Editing-focus-clicked-cell.git
   cd EJ2-DataGrid-Core-Editing-focus-clicked-cell
   ```

2. Restore the required NuGet packages:

   ```bash
   dotnet restore
   ```

3. Run the application using the .NET CLI or Visual Studio:

   ```bash
   dotnet run
   ```

Launch the displayed application URL in a browser, click any grid cell, and observe that the clicked cell remains focused when editing is triggered.

## Additional Resources

- [Move the focus to a particular cell instead of first cell while editing a row](https://ej2.syncfusion.com/aspnetcore/documentation/grid/editing/in-line-editing#move-the-focus-to-a-particular-cell-instead-of-first-cell-while-editing-a-row)
- [Syncfusion ASP.NET Core Grid Editing](https://ej2.syncfusion.com/aspnetcore/documentation/grid/editing/)
- [Syncfusion ASP.NET Core Grid Documentation](https://ej2.syncfusion.com/aspnetcore/documentation/grid)
- [Syncfusion ASP.NET Core Demos](https://ej2.syncfusion.com/aspnetcore)
