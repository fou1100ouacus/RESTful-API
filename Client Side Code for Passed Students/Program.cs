﻿
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Text;
using System.Threading.Tasks;
//using Newtonsoft.Json;

namespace StudentApiClient
{
    class Program
    {
        static readonly HttpClient httpClient = new HttpClient();

        static async Task Main(string[] args)
        {
            httpClient.BaseAddress = new Uri("https://localhost:7258/api/ServerSide/passed\r\n\r\n"); // Set this to the correct URI for your API

            await GetAllStudents();

            await GetPassedStudents();

        }






        static async Task GetAllStudents()
        {
            try
            {
                Console.WriteLine("\n_____________________________");
                Console.WriteLine("\nFetching all students...\n");
                //GetAllStudents Method: The endpoint string in
                //the GetFromJsonAsync method has been changed to "All",
                //which matches the [HttpGet("All", Name = "GetAllStudents")] attribute on the server.
                var students = await httpClient.GetFromJsonAsync<List<Student>>("All");

                if (students != null)
                {
                    foreach (var student in students)
                    {
                        Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}, Age: {student.Grade}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        static async Task GetPassedStudents()
        {
            try
            {
                Console.WriteLine("\n_____________________________");
                Console.WriteLine("\nFetching Passed students...\n");
                //GetAllStudents Method: The endpoint string in
                //the GetFromJsonAsync method has been changed to "Passed",
                //which matches the [HttpGet("Passed", Name = "GetPassedStudents")] attribute on the server.
                var students = await httpClient.GetFromJsonAsync<List<Student>>("Passed");

                if (students != null)
                {
                    foreach (var student in students)
                    {
                        Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}, Age: {student.Grade}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

    }





    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }
    }
}
