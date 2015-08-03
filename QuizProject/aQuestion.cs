using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace QuizProject
{
    public class aQuestion
    {
        private int _vid;
        private String _word;
        private String _definition;
        private int _cid;

        public aQuestion(int avid, string aword, string adefinition, int acid)
        {
            vid = avid;
            word = aword;
            definition = adefinition;
            cid = acid;
       }

        public int vid
        {
            set { _vid = value; }
            get { return _vid; }
        }

        public String word
        {
            set { _word = value; }
            get { return _word; }
        }

        public String definition
        {
            set { _definition = value; }
            get { return _definition; }
        }

        public int cid
        {
            set { _cid = value; }
            get { return _cid; }
        }

    }







}