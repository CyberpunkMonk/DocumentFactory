using System;

namespace DocumentFactory {
	/// <summary>
	/// A "ConcreteCreator" class
	/// </summary>
	/// <seealso cref="DocumentFactory.Document" />
	class Resume :Document{
		//Factory Method impl
		public override void CreatePages() {
			Pages.Add(new SkillsPage());
			Pages.Add(new EducationPage());
			Pages.Add(new ExperiencePage());

		}
	}
}
