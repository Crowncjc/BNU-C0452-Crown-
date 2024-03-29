﻿using System;
using System.Collections.Generic;
using ConsoleAppProject;



namespace ConsoleAppProject.App04
{
    ///<summary>
    /// The NewsFeed class stores news posts for the news feed in a social network 
    /// application.
    /// 
    /// Display of the posts is currently simulated by printing the details to the
    /// terminal. (Later, this should display in a browser.)
    /// 
    /// This version does not save the data to disk, and it does not provide any
    /// search or ordering functions.
    ///</summary>
    ///<author>
    ///  Michael Kölling and David J. Barnes
    ///  version 0.1
    ///</author> 
    public class NewsFeed
    {
        public const string AUTHOR = "Crown";

        private readonly List<Post> posts;

        ///<summary>
        /// Construct an empty news feed.
        ///</summary>
        public NewsFeed()
        {
            posts = new List<Post>();

            MessagePost post = new MessagePost(AUTHOR, "This is one of A Boogies best Albums!");
            AddMessagePost(post);

            PhotoPost photopost = new PhotoPost(AUTHOR, "mevsmyself.jpg", "Album = Me vs Myself");
            AddPhotoPost(photopost);

        }


        ///<summary>
        /// Add a text post to the news feed.
        /// 
        /// @param text  The text post to be added.
        ///</summary>
        public void AddMessagePost(MessagePost message)
        {
            posts.Add(message);
        }

        ///<summary>
        /// Add a photo post to the news feed.
        /// 
        /// @param photo  The photo post to be added.
        ///</summary>
        public void AddPhotoPost(PhotoPost photo)
        {
            posts.Add(photo);
        }

        public void RemovePost(int id)
        {
            Post post = FindPost(id);

            if (post == null)
            {
                Console.WriteLine($"\nPost with ID number {id} doesn not exist");
            }
            else
            {
                Console.WriteLine($"\nPost ID {id} has been sucessfully removed");

                posts.Remove(post);
                post.Display();
            }
        }

        public void AddComment(int id, string comment)
        {
            Post post = FindPost(id);
            if (post == null)
            {
                Console.WriteLine($"\nPost with ID number {id} doesn not exist");
            }
            else
            {
                Console.WriteLine($"\nComment added to post ID {id}");
                post.AddComment(comment);

            }
        }

        public void AddLike(int id)
        {
            Post post = FindPost(id);
            if (post == null)
            {
                Console.WriteLine($"\nPost with ID number {id} doesn not exist");
            }
            else
            {
                Console.WriteLine($"\nLike added to post ID {id}");
            }
            post.Like();
        }

        public void UnlikePost(int id)
        {
            Post post = FindPost(id);
            if (post == null)
            {
                Console.WriteLine($"\nPost with ID number {id} doesn not exist");
            }
            else
            {
                Console.WriteLine($"\nUnliked post ID {id}");
            }
            post.Unlike();
        }

        /// <summary>
        /// Displays all the text by specific user
        /// </summary>
        public void DisplayByAuthor(string author)
        {
            int count = 0;
            // display all text posts
            foreach (Post post in posts)
            {
                if (post.Username == author)
                {
                    count++;
                    post.Display();
                    Console.WriteLine();
                }

            }
            if (count == 0)
            {
                Console.WriteLine("No posts by this user");
            }
        }

        /// <summary>
        /// use a specific post ID to locate a post
        /// </summary>
        public Post FindPost(int id)
        {
            foreach (Post post in posts)
            {
                if (post.PostID == id)
                {
                    return post;
                }
            }
            return null;
        }

        ///<summary>
        /// Show the news feed. Currently: print the news feed details to the
        /// terminal. (To do: replace this later with display in web browser.)
        ///</summary>
        public void Display()
        {
            // display all text posts
            foreach (Post post in posts)
            {
                post.Display();
                Console.WriteLine();   // empty line between posts
            }
        }
    }

}
