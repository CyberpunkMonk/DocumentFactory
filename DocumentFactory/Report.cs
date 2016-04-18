using System;
using System.Collections.Generic;

namespace DocumentFactory {
	/// <summary>
	/// A "ConcreteCreator" class
	/// </summary>
	/// <seealso cref="DocumentFactory.Document" />
	class Report:Document{
		public override void CreatePages() {
			Pages.Add(new IntroductionPage());
			Pages.Add(new ResultPage());
			Pages.Add(new ConclusionPage());
			Pages.Add(new SummaryPage());
			Pages.Add(new BibliographyPage());
		}
	}
}
