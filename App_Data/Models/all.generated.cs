using  System;
using  System.Collections.Generic;
using  System.Linq.Expressions;
using  System.Web;
using  Umbraco.Core.Models;
using  Umbraco.Core.Models.PublishedContent;
using  Umbraco.Web;
using  Umbraco.ModelsBuilder.Embedded;
[assembly:ModelsBuilderAssembly(PureLive = true, SourceHash = "52cc7f17380ec66a")]
[assembly:System.Reflection.AssemblyVersion("0.0.0.3")]


// FILE: models.generated.cs

//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v8.8.0
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------













namespace Umbraco.Web.PublishedModels
{
	/// <summary>Master</summary>
	[PublishedModel("master")]
	public partial class Master : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new const string ModelTypeAlias = "master";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Master, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Master(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// MetaDescription
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription => this.Value<string>("metaDescription");

		///<summary>
		/// MetaKeywords
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		[ImplementPropertyType("metaKeywords")]
		public string MetaKeywords => this.Value<string>("metaKeywords");
	}

	/// <summary>Home Page</summary>
	[PublishedModel("homePage")]
	public partial class HomePage : Master
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new const string ModelTypeAlias = "homePage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<HomePage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public HomePage(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Footer
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		[ImplementPropertyType("footer")]
		public global::System.Web.IHtmlString Footer => this.Value<global::System.Web.IHtmlString>("footer");

		///<summary>
		/// MainContent
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		[ImplementPropertyType("mainContent")]
		public global::System.Web.IHtmlString MainContent => this.Value<global::System.Web.IHtmlString>("mainContent");

		///<summary>
		/// SiteTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		[ImplementPropertyType("siteTitle")]
		public string SiteTitle => this.Value<string>("siteTitle");
	}

	/// <summary>Articles Item</summary>
	[PublishedModel("articlesItem")]
	public partial class ArticlesItem : Master
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new const string ModelTypeAlias = "articlesItem";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ArticlesItem, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public ArticlesItem(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// MainContent
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		[ImplementPropertyType("mainContent")]
		public string MainContent => this.Value<string>("mainContent");

		///<summary>
		/// Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		[ImplementPropertyType("title")]
		public string Title => this.Value<string>("title");
	}

	/// <summary>TextPage</summary>
	[PublishedModel("textPage")]
	public partial class TextPage : Master
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new const string ModelTypeAlias = "textPage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<TextPage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public TextPage(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// MainContent
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		[ImplementPropertyType("mainContent")]
		public string MainContent => this.Value<string>("mainContent");
	}

	/// <summary>ArticlesMain</summary>
	[PublishedModel("articlesMain")]
	public partial class ArticlesMain : Master
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new const string ModelTypeAlias = "articlesMain";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ArticlesMain, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public ArticlesMain(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// MainContent
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		[ImplementPropertyType("mainContent")]
		public string MainContent => this.Value<string>("mainContent");

		///<summary>
		/// Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		[ImplementPropertyType("title")]
		public string Title => this.Value<string>("title");
	}

	/// <summary>ProjectsMain</summary>
	[PublishedModel("projectsMain")]
	public partial class ProjectsMain : Master
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new const string ModelTypeAlias = "projectsMain";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ProjectsMain, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public ProjectsMain(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// MainContent
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		[ImplementPropertyType("mainContent")]
		public string MainContent => this.Value<string>("mainContent");

		///<summary>
		/// Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		[ImplementPropertyType("title")]
		public string Title => this.Value<string>("title");
	}

	/// <summary>Projects Item</summary>
	[PublishedModel("projectsItem")]
	public partial class ProjectsItem : Master
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new const string ModelTypeAlias = "projectsItem";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ProjectsItem, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public ProjectsItem(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// MainContent
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		[ImplementPropertyType("mainContent")]
		public string MainContent => this.Value<string>("mainContent");

		///<summary>
		/// Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		[ImplementPropertyType("title")]
		public string Title => this.Value<string>("title");
	}

	/// <summary>Item</summary>
	[PublishedModel("item")]
	public partial class Item : ProjectsMain
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new const string ModelTypeAlias = "item";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Item, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Item(IPublishedContent content)
			: base(content)
		{ }

		// properties
	}

	/// <summary>About</summary>
	[PublishedModel("about")]
	public partial class About : Master
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new const string ModelTypeAlias = "about";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<About, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public About(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Content
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		[ImplementPropertyType("content")]
		public global::Newtonsoft.Json.Linq.JToken Content => this.Value<global::Newtonsoft.Json.Linq.JToken>("content");
	}

	/// <summary>Contact Page</summary>
	[PublishedModel("contactPage")]
	public partial class ContactPage : Master
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new const string ModelTypeAlias = "contactPage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ContactPage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public ContactPage(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// comment
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		[ImplementPropertyType("comment")]
		public string Comment => this.Value<string>("comment");
	}

	/// <summary>Comment</summary>
	[PublishedModel("comment")]
	public partial class Comment : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new const string ModelTypeAlias = "comment";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Comment, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Comment(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Email
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		[ImplementPropertyType("email")]
		public string Email => this.Value<string>("email");

		///<summary>
		/// Message
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		[ImplementPropertyType("message")]
		public string Message => this.Value<string>("message");

		///<summary>
		/// Subject
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		[ImplementPropertyType("subject")]
		public string Subject => this.Value<string>("subject");

		///<summary>
		/// Username
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		[ImplementPropertyType("username")]
		public string Username => this.Value<string>("username");
	}

	/// <summary>User Comments</summary>
	[PublishedModel("userComments")]
	public partial class UserComments : Master
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new const string ModelTypeAlias = "userComments";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UserComments, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public UserComments(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// comment
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		[ImplementPropertyType("comment")]
		public string Comment => this.Value<string>("comment");
	}

	/// <summary>Folder</summary>
	[PublishedModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new const string ModelTypeAlias = "Folder";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Folder(IPublishedContent content)
			: base(content)
		{ }

		// properties
	}

	/// <summary>Image</summary>
	[PublishedModel("Image")]
	public partial class Image : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new const string ModelTypeAlias = "Image";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Image(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Size: in bytes
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		[ImplementPropertyType("umbracoBytes")]
		public long UmbracoBytes => this.Value<long>("umbracoBytes");

		///<summary>
		/// Type
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension => this.Value<string>("umbracoExtension");

		///<summary>
		/// Upload image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		[ImplementPropertyType("umbracoFile")]
		public global::Umbraco.Core.PropertyEditors.ValueConverters.ImageCropperValue UmbracoFile => this.Value<global::Umbraco.Core.PropertyEditors.ValueConverters.ImageCropperValue>("umbracoFile");

		///<summary>
		/// Height: in pixels
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		[ImplementPropertyType("umbracoHeight")]
		public int UmbracoHeight => this.Value<int>("umbracoHeight");

		///<summary>
		/// Width: in pixels
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		[ImplementPropertyType("umbracoWidth")]
		public int UmbracoWidth => this.Value<int>("umbracoWidth");
	}

	/// <summary>File</summary>
	[PublishedModel("File")]
	public partial class File : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new const string ModelTypeAlias = "File";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public File(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Size: in bytes
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		[ImplementPropertyType("umbracoBytes")]
		public long UmbracoBytes => this.Value<long>("umbracoBytes");

		///<summary>
		/// Type
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension => this.Value<string>("umbracoExtension");

		///<summary>
		/// Upload file
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		[ImplementPropertyType("umbracoFile")]
		public string UmbracoFile => this.Value<string>("umbracoFile");
	}

	/// <summary>Member</summary>
	[PublishedModel("Member")]
	public partial class Member : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new const string ModelTypeAlias = "Member";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Member, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Member(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Is Approved
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved => this.Value<bool>("umbracoMemberApproved");

		///<summary>
		/// Comments
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments => this.Value<string>("umbracoMemberComments");

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public int UmbracoMemberFailedPasswordAttempts => this.Value<int>("umbracoMemberFailedPasswordAttempts");

		///<summary>
		/// Last Lockout Date
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public global::System.DateTime UmbracoMemberLastLockoutDate => this.Value<global::System.DateTime>("umbracoMemberLastLockoutDate");

		///<summary>
		/// Last Login Date
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public global::System.DateTime UmbracoMemberLastLogin => this.Value<global::System.DateTime>("umbracoMemberLastLogin");

		///<summary>
		/// Last Password Change Date
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public global::System.DateTime UmbracoMemberLastPasswordChangeDate => this.Value<global::System.DateTime>("umbracoMemberLastPasswordChangeDate");

		///<summary>
		/// Is Locked Out
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut => this.Value<bool>("umbracoMemberLockedOut");

		///<summary>
		/// Password Answer
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public global::System.DateTime UmbracoMemberPasswordRetrievalAnswer => this.Value<global::System.DateTime>("umbracoMemberPasswordRetrievalAnswer");

		///<summary>
		/// Password Question
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public global::System.DateTime UmbracoMemberPasswordRetrievalQuestion => this.Value<global::System.DateTime>("umbracoMemberPasswordRetrievalQuestion");
	}

}



// EOF
