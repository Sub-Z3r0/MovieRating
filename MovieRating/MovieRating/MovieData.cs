﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MovieRating
{
    public class MovieData : IMovieData
    {
        public List<Reviews> list;

        //This method is someway a layout.
        //public void JustBasic()
        //{
        //    using (StreamReader r = new StreamReader("C:/Users/Samuel/Downloads/ratings.json"))
        //    {
        //        Console.WriteLine("Reading File...");
        //        var json = r.ReadToEnd();
        //        List<Reviews> list = JsonConvert.DeserializeObject<List<Reviews>>(json);
        //        Console.WriteLine("Deserialization finished.");

        //        Console.WriteLine("Do you want start taking shits?");
        //        string val = Console.ReadLine();
        //        if (val == "Yes")
        //        {
        //            Console.WriteLine("Write");
        //            int number = Convert.ToInt32(Console.ReadLine());
        //            foreach (var item in list.Where(w => w.Reviewer == number))
        //            {
        //                Console.WriteLine("Reviewer " + item.Reviewer + "Movie " + item.Movie);
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("You decided to dont");
        //        }

        //    }
        //    Console.ReadLine();
        //}
        
        public double AverageGrade(double Reviewer)
        {
            string path = @"W:/Skóli/CompulsoryTDDJSON/ratings.json";
            Console.WriteLine("Works");

            IEnumerable<Reviews> hash = JsonConvert.DeserializeObject<IEnumerable<Reviews>>(File.ReadAllText(path));

            int userInput = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            foreach (var item in hash.Where(w => w.Reviewer == userInput))
            {
                Console.WriteLine("Reviewer: " + item.Reviewer + " Movie: " + item.Movie + " Grade: " + item.Grade);
                count++;
            }
            Console.WriteLine(count + " amount of Reviews");
            Console.ReadLine();

            return count;
        }

        //On input N, what is the average rate that reviewer N had given?
        public double AverageReviewerGrade(int Movie)
        {
            List<int> gradeList = new List<int>();
            double total = 0;
            double amount = 0;
            foreach (var grade in list.Where(g => g.Reviewer == Movie))
            {
                gradeList.Add(grade.Grade);
                total = total +1;
            }
            foreach (var number in gradeList)
            {
                amount = amount + number;
            }
            double average = amount / total;
            Console.WriteLine("The average of this reviewer is....:" + Math.Round(average, 2));
            
            return average;
           
        }

        public int[] CountReviews()
        {
            string path = @"W:/Skóli/CompulsoryTDDJSON/ratings.json";
            Console.WriteLine("Works");

            IEnumerable<Reviews> hash = JsonConvert.DeserializeObject<IEnumerable<Reviews>>(File.ReadAllText(path));

            int userInput1 = Convert.ToInt32(Console.ReadLine());
            int userInput2 = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            foreach (var item in hash.Where(w => w.Reviewer == userInput1).Where(o => o.Grade == userInput2))
            {
                Console.WriteLine("Reviewer: " + item.Reviewer + " Movie: " + item.Movie + " Grade: " + item.Grade);
                count++;
            }
            Console.WriteLine(count);
            Console.WriteLine("waa");
            Console.ReadLine();
            return count;
        }

        public int[] GetMovieReviewed(int ReviewedMovie)
        {
            throw new NotImplementedException();
        }

        public int[] GetReviewersMovie(int MovieReviewed)
        {
            throw new NotImplementedException();
        }

        public int[] GetTopGradeMovies(int MovieAmount)
        {
            throw new NotImplementedException();
        }

        public int GradeAmount(int Movie, int Grade)
        {
            throw new NotImplementedException();
        }

        public int MovieReviewsAmount(int Movie)
        {
            throw new NotImplementedException();
        }

        public int[] MovieTopGrade()
        {
            throw new NotImplementedException();
        }

        public double ReviewerAmount(int Movie, int Reviewer)
        {
            throw new NotImplementedException();
        }

        public int Reviews(int Reviewer)
        {
            throw new NotImplementedException();
        }
    }
}
