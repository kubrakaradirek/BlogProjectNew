﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProjectNew.DtoLayer.WriterRegisterDto
{
	public class WriterRegisterDto
	{
		public int WriterId { get; set; }
		public string WriterName { get; set; }
		public string WriterAbout { get; set; }
		public string WriterImage { get; set; }
		public string WriterMail { get; set; }
		public string WriterPassword { get; set; }
		public bool WriterStatus { get; set; }
	}
}
