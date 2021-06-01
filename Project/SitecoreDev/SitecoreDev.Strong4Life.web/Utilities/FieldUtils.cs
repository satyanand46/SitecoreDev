using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreDev.Strong4Life.web.Utilities
{
    public class FieldUtils
    {
        /// <summary>
        /// Alias Fields
        /// </summary>
        public struct Alias
        {
            /// <summary>
            /// The link
            /// </summary>
            public const string Link = "Link";
        }

        /// <summary>
        /// SEO Fields
        /// </summary>
        public struct Seo
        {
            /// <summary>
            /// The title
            /// </summary>
            public const string Title = "Title";

            /// <summary>
            /// The description
            /// </summary>
            public const string Description = "Description";

            /// <summary>
            /// The keywords
            /// </summary>
            public const string Keywords = "Keywords";
        }

        /// <summary>
        /// Contact Fields
        /// </summary>
        public struct Contact
        {
            /// <summary>
            /// The first name
            /// </summary>
            public const string FirstName = "First Name";

            /// <summary>
            /// The last name
            /// </summary>
            public const string LastName = "Last Name";

            /// <summary>
            /// The title
            /// </summary>
            public const string Title = "Title";

            /// <summary>
            /// The phone numbers
            /// </summary>
            public const string PhoneNumbers = "Phone Numbers";

            /// <summary>
            /// The email address
            /// </summary>
            public const string EmailAddress = "Email Address";
        }

        /// <summary>
        /// Location List Fields
        /// </summary>
        public struct LocationList
        {
            /// <summary>
            /// The introduction text
            /// </summary>
            public const string IntroductionText = "Introduction Text";

            /// <summary>
            /// The location types
            /// </summary>
            public const string LocationTypes = "Location Types";

            /// <summary>
            /// The location service lines
            /// </summary>
            public const string LocationServiceLines = "Location Service Lines";

            /// <summary>
            /// The closing text
            /// </summary>
            public const string ClosingText = "Closing Text";

            /// <summary>
            /// The view all locations link
            /// </summary>
            public const string ViewAllLocationsLink = "View All Locations Link";

            /// <summary>
            /// The view all locations link text
            /// </summary>
            public const string ViewAllLocationsLinkText = "View All Locations Link Text";
        }

        /// <summary>
        /// Meet The Team Fields
        /// </summary>
        public struct MeetTheTeam
        {
            /// <summary>
            /// The title
            /// </summary>
            public const string Title = "Title";

            /// <summary>
            /// The introduction text
            /// </summary>
            public const string IntroductionText = "Introduction Text";

            /// <summary>
            /// The team members
            /// </summary>
            public const string TeamMembers = "Team Members";

            /// <summary>
            /// The closing text
            /// </summary>
            public const string ClosingText = "Closing Text";

            /// <summary>
            /// The provider bio page
            /// </summary>
            public const string ProviderBioPage = "Provider Bio Page";
        }

        /// <summary>
        /// Biolerplate Fields
        /// </summary>
        public struct Biolerplate
        {
            /// <summary>
            /// The title
            /// </summary>
            public const string Title = "Title";

            /// <summary>
            /// The content
            /// </summary>
            public const string Content = "Content";
        }

        /// <summary>
        /// News Types
        /// </summary>
        public struct NewsTypes
        {
            /// <summary>
            /// The internal
            /// </summary>
            public const string Internal = "Internal";

            /// <summary>
            /// The external
            /// </summary>
            public const string External = "External";
        }

        /// <summary>
        /// Page Types
        /// </summary>
        public struct PageTypes
        {
            /// <summary>
            /// The events
            /// </summary>
            public const string Events = "Events";

            /// <summary>
            /// The locations
            /// </summary>
            public const string Locations = "Locations";

            /// <summary>
            /// The news
            /// </summary>
            public const string News = "News";

            /// <summary>
            /// The other
            /// </summary>
            public const string Other = "Other";

            /// <summary>
            /// The research
            /// </summary>
            public const string Research = "Research";

            /// <summary>
            /// The resources
            /// </summary>
            public const string Resources = "Resources";

            /// <summary>
            /// The services and conditions
            /// </summary>
            public const string ServicesAndConditions = "Services and Conditions";

            /// <summary>
            /// The stories
            /// </summary>
            public const string Stories = "Stories";

            /// <summary>
            /// The medical professionals
            /// </summary>
            public const string MedicalProfessionals = "Medical Professionals";

            /// <summary>
            /// Blog
            /// </summary>
            public const string Blog = "Blog";

            /// <summary>
            /// ParentResource
            /// </summary>
            public const string ParentResource = "Parent Resource";

            /// <summary>
            /// Cap pages
            /// </summary>
            public const string Cap = "CAP";
        }

        /// <summary>
        /// Phone Number Fields
        /// </summary>
        public struct PhoneNumber
        {
            /// <summary>
            /// The number
            /// </summary>
            public const string Number = "Number";

            /// <summary>
            /// The display text
            /// </summary>
            public const string DisplayText = "Display Text";
        }

        /// <summary>
        /// Page Fields
        /// </summary>
        public struct Page
        {
            /// <summary>
            /// The display name
            /// </summary>
            public const string DisplayName = "Display Name";

            /// <summary>
            /// The navigation group
            /// </summary>
            public const string NavigationGroup = "Navigation Group";

            /// <summary>
            /// The exclude from navigation
            /// </summary>
            public const string ExcludeFromNavigation = "Exclude from Navigation";

            /// <summary>
            /// The heroes
            /// </summary>
            public const string Heroes = "Heroes";

            /// <summary>
            /// The page type
            /// </summary>
            public const string PageType = "Page Type";

            /// <summary>
            /// The services and conditions
            /// </summary>
            public const string ServicesAndConditions = "Services and Conditions";

            /// <summary>
            /// The exclude from search
            /// </summary>
            public const string ExcludeFromSearch = "Exclude From Search";

            /// <summary>
            /// The thumbnail image
            /// </summary>
            public const string ThumbnailImage = "Thumbnail Image";
        }

        /// <summary>
        /// Provider Bio Page Fields
        /// </summary>
        public struct ProviderBioPage
        {
            /// <summary>
            /// The hero image
            /// </summary>
            public const string HeroImage = "Hero Image";

            /// <summary>
            /// The hero headline
            /// </summary>
            public const string HeroHeadline = "Hero Headline";

            /// <summary>
            /// The hero body
            /// </summary>
            public const string HeroBody = "Hero Body";

            /// <summary>
            /// The hero link
            /// </summary>
            public const string HeroLink = "Hero Link";

            /// <summary>
            /// The hero link text
            /// </summary>
            public const string HeroLinkText = "Hero Link Text";

            /// <summary>
            /// My chart page
            /// </summary>
            public const string MyChartPage = "MYchart Page";
        }

        public struct GlobalProviderBioPage
        {
            public const string VideoGalleryTitle = "Video Gallery Title";
        }

        /// <summary>
        /// Alert Page Fields
        /// </summary>
        public struct AlertPage
        {
            /// <summary>
            /// The alert
            /// </summary>
            public const string Alert = "Alert";
        }

        /// <summary>
        /// Page Navigation Group Fields
        /// </summary>
        public struct PageNavigationGroup
        {
            /// <summary>
            /// The group title
            /// </summary>
            public const string GroupTitle = "Group Title";

            /// <summary>
            /// The show group title in navigation
            /// </summary>
            public const string ShowGroupTitleInNavigation = "Show Group Title In Navigation";
        }

        /// <summary>
        /// Right Rail
        /// </summary>
        public struct RightRail
        {
            /// <summary>
            /// The do not inherit calendar
            /// </summary>
            public const string DoNotInheritCalendar = "Do Not Inherit Calendar";

            /// <summary>
            /// The show calendar
            /// </summary>
            public const string ShowCalendar = "Show Calendar";

            /// <summary>
            /// The do not inherit featured links
            /// </summary>
            public const string DoNotInheritFeaturedLinks = "Do Not Inherit Featured Links";

            /// <summary>
            /// The featured links
            /// </summary>
            public const string RightRailFeaturedLinks = "Featured Links";

            /// <summary>
            /// The do not inherit quick links
            /// </summary>
            public const string DoNotInheritQuickLinks = "Do Not Inherit Quick Links";

            /// <summary>
            /// The quick links
            /// </summary>
            public const string QuickLinks = "Quick Links";

            /// <summary>
            /// The do not inherit related topics
            /// </summary>
            public const string DoNotInheritRelatedTopics = "Do Not Inherit Related Topics";

            /// <summary>
            /// The related topics
            /// </summary>
            public const string RelatedTopics = "Related Topics";

            /// <summary>
            /// The do not inherit contact us
            /// </summary>
            public const string DoNotInheritContactUs = "Do Not Inherit Contact Us";

            /// <summary>
            /// The contact links
            /// </summary>
            public const string ContactUs = "Contact Us";

            /// <summary>
            /// The do not inherit contact us blurb
            /// </summary>
            public const string DoNotInheritContactUsBlurb = "Do Not Inherit Contact Us Blurb";

            /// <summary>
            /// The contact us blurb
            /// </summary>
            public const string ContactUsBlurb = "Contact Us Blurb";

            /// <summary>
            /// The sections
            /// </summary>
            public const string Sections = "Sections";

            /// <summary>
            /// The do not inherit sharing
            /// </summary>
            public const string DoNotInheritSharing = "Do Not Inherit Sharing";

            /// <summary>
            /// The allow sharing
            /// </summary>
            public const string AllowSharing = "Allow Sharing";
        }

        /// <summary>
        /// Right Rail Featured Link
        /// </summary>
        public struct RightRailFeaturedLink
        {
            /// <summary>
            /// The link
            /// </summary>
            public const string Link = "Link";

            /// <summary>
            /// The title
            /// </summary>
            public const string Title = "Title";

            /// <summary>
            /// The icon key
            /// </summary>
            public const string IconKey = "Icon Key";
        }

        /// <summary>
        /// Home Page Fields
        /// </summary>
        public struct HomePage
        {
            /// <summary>
            /// The introduction text
            /// </summary>
            public const string IntroductionText = "Introduction Text";

            /// <summary>
            /// The call to action
            /// </summary>
            public const string CallToAction = "Call To Action";

            /// <summary>
            /// The featured pods
            /// </summary>
            public const string FeaturedPods = "Featured Pods";

            /// <summary>
            /// The non featured pods
            /// </summary>
            public const string NonFeaturedPods = "Non Featured Pods";

            /// <summary>
            /// The non featured pods
            /// </summary>
            public const string IconPods = "Icon Pods";

            /// <summary>
            /// The non featured pods
            /// </summary>
            public const string ArticlePods = "Article Pods";

            /// <summary>
            /// The non featured pods
            /// </summary>
            public const string LandingPods = "Landing Pods";
        }

        /// <summary>
        /// Find a Doctor fields
        /// </summary>
        public struct FindADoctor
        {
            /// <summary>
            /// The disclaimer
            /// </summary>
            public const string Disclaimer = "Disclaimer";

            /// <summary>
            /// My chart page
            /// </summary>
            public const string MyChartPage = "MYchart Page";
        }

        /// <summary>
        /// Find A Clinical Trial Page Fields
        /// </summary>
        public struct FindAClinicalTrialPage
        {
            /// <summary>
            /// The section title
            /// </summary>
            public const string SectionTitle = "Section Title";

            /// <summary>
            /// The introduction text
            /// </summary>
            public const string IntroductionText = "Introduction Text";

            /// <summary>
            /// The content components
            /// </summary>
            public const string ContentComponents = "Content Components";

            /// <summary>
            /// The closing text
            /// </summary>
            public const string ClosingText = "Closing Text";

            /// <summary>
            /// The first name
            /// </summary>
            public const string FirstName = "First Name";

            /// <summary>
            /// The last name
            /// </summary>
            public const string LastName = "Last Name";

            /// <summary>
            /// The job title
            /// </summary>
            public const string JobTitle = "Job Title";

            /// <summary>
            /// The address line1
            /// </summary>
            public const string AddressLine1 = "Address Line 1";

            /// <summary>
            /// The address line2
            /// </summary>
            public const string AddressLine2 = "Address Line 2";

            /// <summary>
            /// The city
            /// </summary>
            public const string City = "City";

            /// <summary>
            /// The state
            /// </summary>
            public const string State = "State";

            /// <summary>
            /// The zip
            /// </summary>
            public const string Zip = "Zip";

            /// <summary>
            /// The phone number
            /// </summary>
            public const string PhoneNumber = "Phone Number";

            /// <summary>
            /// The fax number
            /// </summary>
            public const string FaxNumber = "Fax Number";

            /// <summary>
            /// The email address
            /// </summary>
            public const string EmailAddress = "Email Address";
        }

        /// <summary>
        /// Featured Pod Fields
        /// </summary>
        public struct FeaturedPod
        {
            /// <summary>
            /// The image
            /// </summary>
            public const string Image = "Image";

            /// <summary>
            /// The heading
            /// </summary>
            public const string Heading = "Heading";

            /// <summary>
            /// The sub heading
            /// </summary>
            public const string SubHeading = "Sub Heading";

            /// <summary>
            /// The icon key
            /// </summary>
            public const string IconKey = "Icon Key";

            /// <summary>
            /// The link
            /// </summary>
            public const string Link = "Link";
        }

        /// <summary>
        /// MYchart Pod Fields
        /// </summary>
        public struct MyChartPod
        {
            /// <summary>
            /// The image
            /// </summary>
            public const string Image = "Image";

            /// <summary>
            /// The heading
            /// </summary>
            public const string Heading = "Heading";

            /// <summary>
            /// The sub heading
            /// </summary>
            public const string SubHeading = "Sub Heading";

            /// <summary>
            /// The link
            /// </summary>
            public const string Link = "Link";
        }

        /// <summary>
        /// Patient Story Pod Fields
        /// </summary>
        public struct PatientStoryPod
        {
            /// <summary>
            /// The image
            /// </summary>
            public const string Image = "Image";

            /// <summary>
            /// The heading
            /// </summary>
            public const string Heading = "Heading";

            /// <summary>
            /// The sub heading
            /// </summary>
            public const string SubHeading = "Sub Heading";

            /// <summary>
            /// The link
            /// </summary>
            public const string Link = "Link";
        }

        /// <summary>
        /// Twitter Pod Fields
        /// </summary>
        public struct TwitterPod
        {
            /// <summary>
            /// The maximum tweets
            /// </summary>
            public const string MaxTweets = "Max Tweets";
        }

        /// <summary>
        /// Facebook Pod Fields
        /// </summary>
        public struct FacebookPod
        {
            /// <summary>
            /// The post image
            /// </summary>
            public const string PostImage = "Post Image";

            /// <summary>
            /// The post text
            /// </summary>
            public const string PostText = "Post Text";

            /// <summary>
            /// The post link
            /// </summary>
            public const string PostLink = "Post Link";
        }

        /// <summary>
        /// Info Pod Fields
        /// </summary>
        public struct InfoPod
        {
            /// <summary>
            /// The title
            /// </summary>
            public const string Title = "Title";

            /// <summary>
            /// The icon key
            /// </summary>
            public const string IconKey = "Icon Key";

            /// <summary>
            /// The text
            /// </summary>
            public const string Text = "Text";

            /// <summary>
            /// The link
            /// </summary>
            public const string Link = "Link";
        }

        /// <summary>
        /// Image Pod
        /// </summary>
        public struct ImagePod
        {
            /// <summary>
            /// The image
            /// </summary>
            public const string Image = "Image";
        }


        /// <summary>
        /// Hero Fields
        /// </summary>
        public struct Hero
        {
            /// <summary>
            /// The image
            /// </summary>
            public const string Image = "Image";

            /// <summary>
            /// The title
            /// </summary>
            public const string Title = "Title";

            /// <summary>
            /// The text
            /// </summary>
            public const string Text = "Text";

            /// <summary>
            /// The icon
            /// </summary>
            public const string Icon = "Icon";

            /// <summary>
            /// The link
            /// </summary>
            public const string Link = "Link";

            /// <summary>
            /// The link text
            /// </summary>
            public const string LinkText = "Link Text";

            /// <summary>
            /// The link text
            /// </summary>
            public const string JumboOverlay = "Overlay Class";


        }

        /// <summary>
        /// The ListPod
        /// </summary>
        public struct ListPod
        {
            /// <summary>
            /// The headline
            /// </summary>
            public const string Headline = "Headline";

            /// <summary>
            /// The body
            /// </summary>
            public const string Body = "Body";

            /// <summary>
            /// The link
            /// </summary>
            public const string CallToActionLink = "Call To Action Link";
        }

        /// <summary>
        /// Pod Container
        /// </summary>
        public struct PodContainer
        {
            /// <summary>
            /// The photo pods
            /// </summary>
            public const string Pods = "Pods";
        }

        /// <summary>
        /// Photo Pod
        /// </summary>
        public struct PhotoPod
        {
            /// <summary>
            /// The image
            /// </summary>
            public const string Image = "Image";

            /// <summary>
            /// The link
            /// </summary>
            public const string Link = "Link";

            /// <summary>
            /// The link text
            /// </summary>
            public const string Title = "Title";
        }


        /// <summary>
        /// Media Image
        /// </summary>
        public struct MediaImage
        {
            /// <summary>
            /// The image
            /// </summary>
            public const string Image = "Image";

            /// <summary>
            /// The link
            /// </summary>
            public const string Link = "Link";

            /// <summary>
            /// The image type
            /// </summary>
            public const string ImageType = "Image Type";

        }

        /// <summary>
        /// Media Quote for Blog
        /// </summary>
        public struct MediaBlogQuote
        {

            public const string QuoteText = "Quote Text";

            public const string QuoteTextEnabled = "Quote Text Enabled";

            public const string QuoteTextAlignment = "Quote Text Alignment";
        }

        /// <summary>
        /// Media Image
        /// </summary>
        public struct MediaVideo
        {
            /// <summary>
            /// The image
            /// </summary>
            public const string Image = "Image";

            /// <summary>
            /// The text
            /// </summary>
            public const string Text = "Text";

            /// <summary>
            /// The link
            /// </summary>
            public const string Link = "Link";

            /// <summary>
            /// The caption
            /// </summary>
            public const string Caption = "Caption";

            /// <summary>
            /// The icon
            /// </summary>
            public const string Icon = "Icon";
        }

        /// <summary>
        /// Accordion
        /// </summary>
        public struct Accordion
        {
            /// <summary>
            /// The title
            /// </summary>
            public const string Title = "Title";

            /// <summary>
            /// The introduction text
            /// </summary>
            public const string IntroductionText = "Introduction Text";

            /// <summary>
            /// The accordion title
            /// </summary>
            public const string AccordionTitle = "Accordion Title";

            /// <summary>
            /// The accordion introduction text
            /// </summary>
            public const string AccordionIntroductionText = "Accordion Introduction Text";

            /// <summary>
            /// The accordion content component
            /// </summary>
            public const string AccordionContentComponents = "Accordion Content Components";

            /// <summary>
            /// The accordion closing text
            /// </summary>
            public const string AccordionClosingText = "Accordion Closing Text";

            /// <summary>
            /// The closing text
            /// </summary>
            public const string ClosingText = "Closing Text";
        }

        /// <summary>
        /// Mini Accordion
        /// </summary>
        public struct MiniAccordion
        {
            /// <summary>
            /// The accordion title
            /// </summary>
            public const string AccordionTitle = "Accordion Title";

            /// <summary>
            /// The accordion introduction text
            /// </summary>
            public const string AccordionIntroductionText = "Accordion Introduction Text";
        }

        /// <summary>
        /// News Landing Page
        /// </summary>
        public struct NewsLandingPage
        {
            /// <summary>
            /// The top section title
            /// </summary>
            public const string TopSectionTitle = "Top Section Title";

            /// <summary>
            /// The top section short title
            /// </summary>
            public const string TopSectionShortTitle = "Top Section Short Title";

            /// <summary>
            /// The news
            /// </summary>
            public const string News = "News";

            /// <summary>
            /// The sections
            /// </summary>
            public const string Sections = "Sections";
        }

        /// <summary>
        /// News Details Page Fields
        /// </summary>
        public struct NewsDetailsPage
        {
            /// <summary>
            /// The headline
            /// </summary>
            public const string Headline = "Headline";

            /// <summary>
            /// The subheadline
            /// </summary>
            public const string Subheadline = "Subheadline";

            /// <summary>
            /// The date released
            /// </summary>
            public const string DateReleased = "Date Released";

            /// <summary>
            /// The image
            /// </summary>
            public const string Image = "Image";

            /// <summary>
            /// The has video
            /// </summary>
            public const string HasVideo = "Has Video";

            /// <summary>
            /// The introduction text
            /// </summary>
            public const string IntroductionText = "Introduction Text";

            /// <summary>
            /// The content components
            /// </summary>
            public const string ContentComponents = "Content Components";

            /// <summary>
            /// The closing text
            /// </summary>
            public const string ClosingText = "Closing Text";

            /// <summary>
            /// The contacts
            /// </summary>
            public const string Contacts = "Contacts";

            /// <summary>
            /// The boilerplates
            /// </summary>
            public const string Boilerplates = "Boilerplates";

            /// <summary>
            /// The affiliate boilerplate
            /// </summary>
            public const string AffiliateBoilerplate = "Affiliate Boilerplate";

            /// <summary>
            /// The affiliate name
            /// </summary>
            public const string AffiliateName = "Affiliate Name";

            /// <summary>
            /// The affiliate link
            /// </summary>
            public const string AffiliateLink = "Affiliate Link";

            /// <summary>
            /// The affiliate logo
            /// </summary>
            public const string AffiliateLogo = "Affiliate Logo";

            /// <summary>
            /// The external news link
            /// </summary>
            public const string ExternalNewsLink = "External News Link";

            /// <summary>
            /// The hero image
            /// </summary>
            public const string HeroImage = "Hero Image";

            /// <summary>
            /// The hero headline
            /// </summary>
            public const string HeroHeadline = "Hero Headline";

            /// <summary>
            /// The hero body
            /// </summary>
            public const string HeroBody = "Hero Body";

            /// <summary>
            /// The hero link
            /// </summary>
            public const string HeroLink = "Hero Link";

            /// <summary>
            /// The hero link text
            /// </summary>
            public const string HeroLinkText = "Hero Link Text";
        }

        /// <summary>
        /// Category Page Fields
        /// </summary>
        public struct CategoryPage
        {
            /// <summary>
            /// The row1 section title
            /// </summary>
            public const string Row1SectionTitle = "Row 1 Section Title";

            /// <summary>
            /// The row1 pods
            /// </summary>
            public const string Row1Pods = "Row 1 Pods";

            /// <summary>
            /// The row1 split information pods on mobile
            /// </summary>
            public const string Row1SplitPodsOnMobile = "Row 1 Split Pods On Mobile";

            /// <summary>
            /// The row1 split information pods title on mobile
            /// </summary>
            public const string Row1SplitPodsTitleOnMobile = "Row 1 Split Pods Title On Mobile";

            /// <summary>
            /// The row2 section title
            /// </summary>
            public const string Row2SectionTitle = "Row 2 Section Title";

            /// <summary>
            /// The row2 pods
            /// </summary>
            public const string Row2Pods = "Row 2 Pods";

            /// <summary>
            /// The row2 split information pods on mobile
            /// </summary>
            public const string Row2SplitPodsOnMobile = "Row 2 Split Pods On Mobile";

            /// <summary>
            /// The row2 split information pods title on mobile
            /// </summary>
            public const string Row2SplitPodsTitleOnMobile = "Row 2 Split Pods Title On Mobile";

            /// <summary>
            /// The row3 section title
            /// </summary>
            public const string Row3SectionTitle = "Row 3 Section Title";

            /// <summary>
            /// The row3 pods
            /// </summary>
            public const string Row3Pods = "Row 3 Pods";

            /// <summary>
            /// The row3 split information pods on mobile
            /// </summary>
            public const string Row3SplitPodsOnMobile = "Row 3 Split Pods On Mobile";

            /// <summary>
            /// The row3 split information pods title on mobile
            /// </summary>
            public const string Row3SplitPodsTitleOnMobile = "Row 3 Split Pods Title On Mobile";

            /// <summary>
            /// The row4 section title
            /// </summary>
            public const string Row4SectionTitle = "Row 4 Section Title";

            /// <summary>
            /// The row4 pods
            /// </summary>
            public const string Row4Pods = "Row 4 Pods";

            /// <summary>
            /// The row4 split information pods on mobile
            /// </summary>
            public const string Row4SplitPodsOnMobile = "Row 4 Split Pods On Mobile";

            /// <summary>
            /// The row4 split information pods title on mobile
            /// </summary>
            public const string Row4SplitPodsTitleOnMobile = "Row 4 Split Pods Title On Mobile";

            /// <summary>
            /// The row5 section title
            /// </summary>
            public const string Row5SectionTitle = "Row 5 Section Title";

            /// <summary>
            /// The row5 pods
            /// </summary>
            public const string Row5Pods = "Row 5 Pods";

            /// <summary>
            /// The row5 split information pods on mobile
            /// </summary>
            public const string Row5SplitPodsOnMobile = "Row 5 Split Pods On Mobile";

            /// <summary>
            /// The row5 split information pods title on mobile
            /// </summary>
            public const string Row5SplitPodsTitleOnMobile = "Row 5 Split Pods Title On Mobile";

            /// <summary>
            /// The row6 call to action
            /// </summary>
            public const string Row6CallToAction = "Row 6 Call To Action";

            /// <summary>
            /// The row6 section title
            /// </summary>
            public const string Row6SectionTitle = "Row 6 Section Title";

            /// <summary>
            /// The row6 link lists
            /// </summary>
            public const string Row6LinkLists = "Row 6 Link Lists";

        }

        /// <summary>
        /// Condition Page Fields
        /// </summary>
        public struct ConditionPage
        {
            /// <summary>
            /// The sections
            /// </summary>
            public const string Sections = "Sections";

            /// <summary>
            /// The sections
            /// </summary>
            public const string Boost = "Boost";
        }

        /// <summary>
        /// About Us Page Fields
        /// </summary>
        public struct AboutUsPage
        {
            /// <summary>
            /// The featured pods
            /// </summary>
            public const string FeaturedPods = "Featured Pods";

            /// <summary>
            /// The related contents
            /// </summary>
            public const string RelatedContents = "Related Contents";
        }

        /// <summary>
        /// Patient Stories Landing Page Fields
        /// </summary>
        public struct PatientStoriesLandingPage
        {
            /// <summary>
            /// The patient stories section title
            /// </summary>
            public const string PatientStoriesSectionTitle = "Patient Stories Section Title";

            /// <summary>
            /// The patient stories short section title
            /// </summary>
            public const string PatientStoriesShortSectionTitle = "Patient Stories Short Section Title";

            /// <summary>
            /// The patient stories introduction text
            /// </summary>
            public const string PatientStoriesIntroductionText = "Patient Stories Introduction Text";

            /// <summary>
            /// The patient stories content components
            /// </summary>
            public const string PatientStoriesContentComponents = "Patient Stories Content Components";

            /// <summary>
            /// The patient stories closing text
            /// </summary>
            public const string PatientStoriesClosingText = "Patient Stories Closing Text";

            /// <summary>
            /// The patient stories
            /// </summary>
            public const string PatientStories = "Patient Stories";

            /// <summary>
            /// The patient stories call to action link
            /// </summary>
            public const string PatientStoriesCallToActionLink = "Patient Stories Call To Action Link";

            /// <summary>
            /// The patient stories call to action link text
            /// </summary>
            public const string PatientStoriesCallToActionLinkText = "Patient Stories Call To Action Link Text";

            /// <summary>
            /// The employee stories section title
            /// </summary>
            public const string EmployeeStoriesSectionTitle = "Employee Stories Section Title";

            /// <summary>
            /// The employee stories short section title
            /// </summary>
            public const string EmployeeStoriesShortSectionTitle = "Employee Stories Short Section Title";

            /// <summary>
            /// The employee stories introduction text
            /// </summary>
            public const string EmployeeStoriesIntroductionText = "Employee Stories Introduction Text";

            /// <summary>
            /// The employee stories content components
            /// </summary>
            public const string EmployeeStoriesContentComponents = "Employee Stories Content Components";

            /// <summary>
            /// The employee stories closing text
            /// </summary>
            public const string EmployeeStoriesClosingText = "Employee Stories Closing Text";

            /// <summary>
            /// The employee stories
            /// </summary>
            public const string EmployeeStories = "Employee Stories";

            /// <summary>
            /// The employee stories call to action link
            /// </summary>
            public const string EmployeeStoriesCallToActionLink = "Employee Stories Call To Action Link";

            /// <summary>
            /// The employee stories call to action link text
            /// </summary>
            public const string EmployeeStoriesCallToActionLinkText = "Employee Stories Call To Action Link Text";

        }

        /// <summary>
        /// Patient Story Page Fields
        /// </summary>
        public struct PatientStoryPage
        {
            /// <summary>
            /// The patient story title
            /// </summary>
            public const string PatientStoryTitle = "Patient Story Title";

            /// <summary>
            /// The introduction text
            /// </summary>
            public const string IntroductionText = "Introduction Text";

            /// <summary>
            /// The content components
            /// </summary>
            public const string ContentComponents = "Content Components";

            /// <summary>
            /// The closing text
            /// </summary>
            public const string ClosingText = "Closing Text";

            /// <summary>
            /// The call to action
            /// </summary>
            public const string CallToAction = "Call To Action";

            /// <summary>
            /// The image
            /// </summary>
            public const string Image = "Image";

            /// <summary>
            /// The has video
            /// </summary>
            public const string HasVideo = "Has Video";

            /// <summary>
            /// The type
            /// </summary>
            public const string Type = "Type";
        }

        /// <summary>
        /// Visitor Page Fields
        /// </summary>
        public struct VisitorPage
        {
            /// <summary>
            /// The introduction text
            /// </summary>
            public const string IntroductionText = "Introduction Text";

            /// <summary>
            /// The hospitals
            /// </summary>
            public const string Hospitals = "Hospitals";

            /// <summary>
            /// The type of hospital information
            /// </summary>
            public const string TypeOfHospitalInformation = "Type of Hospital Information";

            /// <summary>
            /// The closing text
            /// </summary>
            public const string ClosingText = "Closing Text";
        }

        /// <summary>
        /// Patient Page Fields
        /// </summary>
        public struct PatientPage
        {
            /// <summary>
            /// The introduction text
            /// </summary>
            public const string IntroductionText = "Introduction Text";

            /// <summary>
            /// The content components
            /// </summary>
            public const string ContentComponents = "Content Components";

            /// <summary>
            /// The closing text
            /// </summary>
            public const string ClosingText = "Closing Text";


        }

        /// <summary>
        /// List Page Fields
        /// </summary>
        public struct ListPage
        {
            /// <summary>
            /// The introduction text
            /// </summary>
            public const string IntroductionText = "Introduction Text";

            /// <summary>
            /// The list pods
            /// </summary>
            public const string ListPods = "List Pods";

            /// <summary>
            /// The closing text
            /// </summary>
            public const string ClosingText = "Closing Text";
        }

        /// <summary>
        /// Utility Single Section Page fields
        /// </summary>
        public struct UtilitySingleSectionPage
        {
            /// <summary>
            /// The section title
            /// </summary>
            public const string SectionTitle = "Section Title";

            /// <summary>
            /// The introduction text
            /// </summary>
            public const string IntroductionText = "Introduction Text";

            /// <summary>
            /// The content components
            /// </summary>
            public const string ContentComponents = "Content Components";

            /// <summary>
            /// The closing text
            /// </summary>
            public const string ClosingText = "Closing Text";
        }

        /// <summary>
        /// Search Results Page Fields
        /// </summary>
        public struct SearchResultsPage
        {
            /// <summary>
            /// The show results for page type
            /// </summary>
            public const string ShowResultsForPageType = "Show Results For Page Type";
        }

        /// <summary>
        /// Events Landing Page Fields
        /// </summary>
        public struct EventsLandingPage
        {
            /// <summary>
            /// The top section title
            /// </summary>
            public const string TopSectionTitle = "Top Section Title";

            /// <summary>
            /// The top section short title
            /// </summary>
            public const string TopSectionShortTitle = "Top Section Short Title";

            /// <summary>
            /// The events
            /// </summary>
            public const string Events = "Events";

            /// <summary>
            /// The sections
            /// </summary>
            public const string Sections = "Sections";

            /// <summary>
            /// All events page link
            /// </summary>
            public const string AllEventsPageLink = "All Events Page Link";

            /// <summary>
            /// All events page link text
            /// </summary>
            public const string AllEventsPageLinkText = "All Events Page Link Text";

            /// <summary>
            /// The event category
            /// </summary>
            public const string EventCategory = "Event Category";
        }

        /// <summary>
        /// External Content Block
        /// </summary>
        public struct ExternalContentBlock
        {
            /// <summary>
            /// The slug
            /// </summary>
            public const string Slug = "Slug";

            /// <summary>
            /// The title
            /// </summary>
            public const string Title = "Title";

            /// <summary>
            /// The blurb
            /// </summary>
            public const string Blurb = "Blurb";

            /// <summary>
            /// The body
            /// </summary>
            public const string Body = "Body";
        }

        /// <summary>
        /// External Content Block Segment
        /// </summary>
        public struct ExternalContentBlockSegment
        {
            /// <summary>
            /// The body
            /// </summary>
            public const string Body = "Body";
        }


        /// <summary>
        /// Location Service Line Fields
        /// </summary>
        public struct LocationServiceLine
        {
            /// <summary>
            /// The title
            /// </summary>
            public const string Title = "Title";

            /// <summary>
            /// The hours
            /// </summary>
            public const string Hours = "Hours";

            /// <summary>
            /// The phone numbers
            /// </summary>
            public const string PhoneNumbers = "Phone Numbers";

            /// <summary>
            /// The email
            /// </summary>
            public const string Email = "Email";

            /// <summary>
            /// The more information
            /// </summary>
            public const string MoreInformation = "More Information";

            /// <summary>
            /// The service line page link
            /// </summary>
            public const string ServiceLinePageLink = "Service Line Page Link";
        }

        /// <summary>
        /// Locations Landing Page
        /// </summary>
        public struct LocationsLandingPage
        {
            /// <summary>
            /// The default location types
            /// </summary>
            public const string DefaultLocationTypes = "Default Location Types";

            /// <summary>
            /// The default location service lines
            /// </summary>
            public const string DefaultLocationServiceLines = "Default Location Service Lines";

            /// <summary>
            /// The wait times page link
            /// </summary>
            public const string WaitTimesPageLink = "Wait Times Page Link";

            /// <summary>
            /// The wait times page link text
            /// </summary>
            public const string WaitTimesPageLinkText = "Wait Times Page Link Text";
        }

        /// <summary>
        /// Location Details Page Fields
        /// </summary>
        public struct LocationDetailsPage
        {
            /// <summary>
            /// The location name
            /// </summary>
            public const string LocationName = "Location Name";

            /// <summary>
            /// The address line1
            /// </summary>
            public const string AddressLine1 = "Address Line 1";

            /// <summary>
            /// The address line2
            /// </summary>
            public const string AddressLine2 = "Address Line 2";

            /// <summary>
            /// The city
            /// </summary>
            public const string City = "City";

            /// <summary>
            /// The state
            /// </summary>
            public const string State = "State";

            /// <summary>
            /// The zip
            /// </summary>
            public const string Zip = "Zip";

            /// <summary>
            /// The image
            /// </summary>
            public const string Image = "Image";

            /// <summary>
            /// The location type
            /// </summary>
            public const string LocationType = "Location Type";

            /// <summary>
            /// The hours
            /// </summary>
            public const string Hours = "Hours";

            /// <summary>
            /// The introduction text
            /// </summary>
            public const string IntroductionText = "Introduction Text";

            /// <summary>
            /// The content components
            /// </summary>
            public const string ContentComponents = "Content Components";

            /// <summary>
            /// The closing text
            /// </summary>
            public const string ClosingText = "Closing Text";

            /// <summary>
            /// The hero image
            /// </summary>
            public const string HeroImage = "Hero Image";

            /// <summary>
            /// The latitude
            /// </summary>
            public const string Latitude = "Latitude";

            /// <summary>
            /// The longitude
            /// </summary>
            public const string Longitude = "Longitude";

            /// <summary>
            /// The phone numbers
            /// </summary>
            public const string PhoneNumbers = "Phone Numbers";

            /// <summary>
            /// The wait time API key
            /// </summary>
            public const string WaitTimeAPIKey = "Wait Time API Key";
        }

        /// <summary>
        /// Location Types
        /// </summary>
        public struct LocationTypes
        {
            /// <summary>
            /// The emergency
            /// </summary>
            public const string Emergency = "Emergency";

            /// <summary>
            /// The urgent care
            /// </summary>
            public const string UrgentCare = "Urgent Care";

            /// <summary>
            /// The telemedicine
            /// </summary>
            public const string Telemedicine = "Telemedicine";

            /// <summary>
            /// The neighborhood
            /// </summary>
            public const string Neighborhood = "Neighborhood";
        }

        /// <summary>
        /// The Event Detail Page
        /// </summary>
        public struct EventDetailsPage
        {

            /// <summary>
            /// The event identifier
            /// </summary>
            public const string Event = "Event";
        }

        /// <summary>
        /// Thank You Page
        /// </summary>
        public struct ThankYouPage
        {
            /// <summary>
            /// The image
            /// </summary>
            public const string Image = "Image";


            /// <summary>
            /// The message title
            /// </summary>
            public const string Message = "Message";

            /// <summary>
            /// The text
            /// </summary>
            public const string Text = "Text";
        }

        /// <summary>
        /// Not Found Page Fields
        /// </summary>
        public struct NotFoundPage
        {
            /// <summary>
            /// The image
            /// </summary>
            public const string Image = "Image";


            /// <summary>
            /// The message title
            /// </summary>
            public const string Message = "Message";

            /// <summary>
            /// The text
            /// </summary>
            public const string Text = "Text";
        }

        /// <summary>
        /// Event
        /// </summary>
        public struct Event
        {
            /// <summary>
            /// The headline
            /// </summary>
            public const string Headline = "Headline";

            /// <summary>
            /// The introduction text
            /// </summary>
            public const string IntroductionText = "Introduction Text";

            /// <summary>
            /// The content components
            /// </summary>
            public const string ContentComponents = "Content Components";

            /// <summary>
            /// The closing text
            /// </summary>
            public const string ClosingText = "Closing Text";

            /// <summary>
            /// The call to action link
            /// </summary>
            public const string CallToActionLink = "Call To Action Link";

            /// <summary>
            /// The call to action link text
            /// </summary>
            public const string CallToActionLinkText = "Call To Action Link Text";

            /// <summary>
            /// The event logo
            /// </summary>
            public const string EventLogo = "Event Logo";

            /// <summary>
            /// The event image
            /// </summary>
            public const string EventImage = "Event Image";

            /// <summary>
            /// The additional information
            /// </summary>
            public const string AdditionalInformation = "Additional Information";

            /// <summary>
            /// The when
            /// </summary>
            public const string When = "When";

            /// <summary>
            /// The contact
            /// </summary>
            public const string Contact = "Contact";

            /// <summary>
            /// The sponsors
            /// </summary>
            public const string Sponsors = "Sponsors";

            /// <summary>
            /// The event types
            /// </summary>
            public const string EventTypes = "Event Types";

            /// <summary>
            /// The start date time
            /// </summary>
            public const string StartDateTime = "Start Date Time";

            /// <summary>
            /// The end date time
            /// </summary>
            public const string EndDateTime = "End Date Time";

            /// <summary>
            /// The location1 name
            /// </summary>
            public const string Location1Name = "Location 1 Name";

            /// <summary>
            /// The location1 address1
            /// </summary>
            public const string Location1Address1 = "Location 1 Address 1";

            /// <summary>
            /// The location1 address2
            /// </summary>
            public const string Location1Address2 = "Location 1 Address 2";

            /// <summary>
            /// The location1 city
            /// </summary>
            public const string Location1City = "Location 1 City";

            /// <summary>
            /// The location1 state
            /// </summary>
            public const string Location1State = "Location 1 State";

            /// <summary>
            /// The location1 zip
            /// </summary>
            public const string Location1Zip = "Location 1 Zip";

            /// <summary>
            /// The location2 name
            /// </summary>
            public const string Location2Name = "Location 2 Name";

            /// <summary>
            /// The location2 address1
            /// </summary>
            public const string Location2Address1 = "Location 2 Address 1";

            /// <summary>
            /// The location2 address2
            /// </summary>
            public const string Location2Address2 = "Location 2 Address 2";

            /// <summary>
            /// The location2 city
            /// </summary>
            public const string Location2City = "Location 2 City";

            /// <summary>
            /// The location2 state
            /// </summary>
            public const string Location2State = "Location 2 State";

            /// <summary>
            /// The location2 zip
            /// </summary>
            public const string Location2Zip = "Location 2 Zip";

            /// <summary>
            /// The location3 name
            /// </summary>
            public const string Location3Name = "Location 3 Name";

            /// <summary>
            /// The location3 address1
            /// </summary>
            public const string Location3Address1 = "Location 3 Address 1";

            /// <summary>
            /// The location3 address2
            /// </summary>
            public const string Location3Address2 = "Location 3 Address 2";

            /// <summary>
            /// The location3 city
            /// </summary>
            public const string Location3City = "Location 3 City";

            /// <summary>
            /// The location3 state
            /// </summary>
            public const string Location3State = "Location 3 State";

            /// <summary>
            /// The location3 zip
            /// </summary>
            public const string Location3Zip = "Location 3 Zip";

            /// <summary>
            /// The hero image
            /// </summary>
            public const string HeroImage = "Hero Image";

            /// <summary>
            /// The hero headline
            /// </summary>
            public const string HeroHeadline = "Hero Headline";

            /// <summary>
            /// The hero body
            /// </summary>
            public const string HeroBody = "Hero Body";

            /// <summary>
            /// The hero location name
            /// </summary>
            public const string HeroLocationName = "Hero Location Name";
        }

        /// <summary>
        /// Content Block Fields
        /// </summary>
        public struct ContentBlock
        {
            /// <summary>
            /// The block title
            /// </summary>
            public const string BlockTitle = "Block Title";

            /// <summary>
            /// The block text
            /// </summary>
            public const string BlockText = "Block Text";

            /// <summary>
            /// The block related content
            /// </summary>
            public const string BlockRelatedContent = "Block Related Content";

            /// <summary>
            /// The block related content position
            /// </summary>
            public const string BlockRelatedContentPosition = "Block Related Content Position";
        }

        /// <summary>
        /// Infographic Carousel Fields
        /// </summary>
        public struct InfographicCarousel
        {
            /// <summary>
            /// The image
            /// </summary>
            public const string Image = "Image";

            /// <summary>
            /// The title
            /// </summary>
            public const string Title = "Title";

            /// <summary>
            /// The title
            /// </summary>
            public const string TitleClass = "Title Class";
        }

        /// <summary>
        /// Infographic fields
        /// </summary>
        public struct Infographic
        {
            /// <summary>
            /// The image
            /// </summary>
            public const string Image = "Image";

            /// <summary>
            /// The title
            /// </summary>
            public const string Title = "Title";

            /// <summary>
            /// The title
            /// </summary>
            public const string TitleClass = "Title Class";
        }

        /// <summary>
        /// Featured Quote Fields
        /// </summary>
        public struct FeaturedQuote
        {
            /// <summary>
            /// The quote text
            /// </summary>
            public const string QuoteText = "Quote Text";

            /// <summary>
            /// The quote author
            /// </summary>
            public const string QuoteAuthor = "Quote Author";
        }

        /// <summary>
        /// Quote Fields
        /// </summary>
        public struct Quote
        {
            /// <summary>
            /// The quote image
            /// </summary>
            public const string QuoteImage = "Quote Image";

            /// <summary>
            /// The quote text
            /// </summary>
            public const string QuoteText = "Quote Text";

            /// <summary>
            /// The quote author
            /// </summary>
            public const string QuoteAuthor = "Quote Author";
        }

        /// <summary>
        /// Utility Link Fields
        /// </summary>
        public struct UtilityLink
        {
            /// <summary>
            /// The title
            /// </summary>
            public const string Title = "Title";

            /// <summary>
            /// The link
            /// </summary>
            public const string Link = "Link";

            /// <summary>
            /// The icon key
            /// </summary>
            public const string IconKey = "Icon Key";
        }

        /// <summary>
        /// Award Fields
        /// </summary>
        public struct Award
        {
            /// <summary>
            /// The logo
            /// </summary>
            public const string Logo = "Logo";

            /// <summary>
            /// The link
            /// </summary>
            public const string Link = "Link";
        }

        /// <summary>
        /// Social Connection Fields
        /// </summary>
        public struct SocialConnection
        {
            /// <summary>
            /// The icon
            /// </summary>
            public const string Icon = "Icon";

            /// <summary>
            /// The link
            /// </summary>
            public const string Link = "Link";
        }

        /// <summary>
        /// Contact Us Method Fields
        /// </summary>
        public struct ContactUsMethod
        {
            /// <summary>
            /// The icon
            /// </summary>
            public const string Icon = "Icon";

            /// <summary>
            /// The link
            /// </summary>
            public const string Link = "Link";
        }

        /// <summary>
        /// Hospital Section Fields
        /// </summary>
        public struct Hospital
        {
            /// <summary>
            /// The hospital name
            /// </summary>
            public const string HospitalName = "Hospital Name";

            /// <summary>
            /// The description
            /// </summary>
            public const string Description = "Description";

            /// <summary>
            /// The call to action
            /// </summary>
            public const string CallToAction = "Call to Action";

            /// <summary>
            /// The address
            /// </summary>
            public const string Address = "Address";

            /// <summary>
            /// The directions header title
            /// </summary>
            public const string DirectionsHeaderTitle = "Directions Header Title";

            /// <summary>
            /// The directions 1 title
            /// </summary>
            public const string Directions1Title = "Directions 1 Title";

            /// <summary>
            /// The directions 1
            /// </summary>
            public const string Directions1 = "Directions 1";

            /// <summary>
            /// The directions 2 title
            /// </summary>
            public const string Directions2Title = "Directions 2 Title";

            /// <summary>
            /// The directions 2
            /// </summary>
            public const string Directions2 = "Directions 2";

            /// <summary>
            /// The directions 3 title
            /// </summary>
            public const string Directions3Title = "Directions 3 Title";

            /// <summary>
            /// The directions 3
            /// </summary>
            public const string Directions3 = "Directions 3";

            /// <summary>
            /// The directions 4 title
            /// </summary>
            public const string Directions4Title = "Directions 4 Title";

            /// <summary>
            /// The directions 4
            /// </summary>
            public const string Directions4 = "Directions 4";

            /// <summary>
            /// The map image
            /// </summary>
            public const string MapImage = "Map Image";

            /// <summary>
            /// The parking rates
            /// </summary>
            public const string ParkingRates = "Parking Rates";

            /// <summary>
            /// The helpful tips
            /// </summary>
            public const string HelpfulTips = "Helpful Tips";

            /// <summary>
            /// The check in information
            /// </summary>
            public const string CheckInInformation = "Check-in Information";

            /// <summary>
            /// The call information
            /// </summary>
            public const string CallInformation = "Call Information";

            /// <summary>
            /// The amenities and services
            /// </summary>
            public const string AmenitiesAndServices = "Amenities and Services";

        }


        /// <summary>
        ///  Section Fields (Formerly Condition Section)
        /// </summary>
        public struct Section
        {
            /// <summary>
            /// The title
            /// </summary>
            public const string Title = "Title";

            /// <summary>
            /// The custom title
            /// </summary>
            public const string CustomTitle = "Custom Title";

            /// <summary>
            /// The short title
            /// </summary>
            public const string ShortTitle = "Short Title";

            /// <summary>
            /// The hide from right navigation
            /// </summary>
            public const string HideFromRightNavigation = "Hide From Right Navigation";

            /// <summary>
            /// The introduction text
            /// </summary>
            public const string IntroductionText = "Introduction Text";

            /// <summary>
            /// The content components
            /// </summary>
            public const string ContentComponents = "Content Components";

            /// <summary>
            /// The closing text
            /// </summary>
            public const string ClosingText = "Closing Text";

            /// <summary>
            /// The related contents
            /// </summary>
            public const string RelatedContents = "Related Contents";

            /// <summary>
            /// The allow form
            /// </summary>
            public const string AllowForm = "Allow Form";
        }

        /// <summary>
        /// Section Title Fields (Formerly Condition Section Title)
        /// </summary>
        public struct SectionTitle
        {
            /// <summary>
            /// The display title
            /// </summary>
            public const string DisplayTitle = "Display Title";

            /// <summary>
            /// The custom title identifier
            /// </summary>
            public const string CustomTitleId = "{1DE87E8C-9F03-4792-B4B2-349F5845D168}";

        }

        /// <summary>
        /// Related Content Type Fields
        /// </summary>
        public struct RelatedContentType
        {
            /// <summary>
            /// The title
            /// </summary>
            public const string Title = "Title";

            /// <summary>
            /// The icon key
            /// </summary>
            public const string IconKey = "Icon Key";

            /// <summary>
            /// The photo gallery type identifier
            /// </summary>
            public const string PhotoGalleryTypeId = "{D237236D-83DF-4361-9B1A-9189FEC34536}";

            /// <summary>
            /// The video type identifier
            /// </summary>
            public const string VideoTypeId = "{97B5D640-DA80-4273-A367-C1D822F66FFE}";
        }

        /// <summary>
        /// Related Content Fields
        /// </summary>
        public struct RelatedContent
        {
            /// <summary>
            /// The single content image
            /// </summary>
            public const string SingleContentImage = "Single Content Image";

            /// <summary>
            /// The multiple content image
            /// </summary>
            public const string MultipleContentImage = "Multiple Content Image";

            /// <summary>
            /// The type
            /// </summary>
            public const string Type = "Type";

            /// <summary>
            /// The text
            /// </summary>
            public const string Text = "Text";

            /// <summary>
            /// The caption
            /// </summary>
            public const string Caption = "Caption";

            /// <summary>
            /// The link
            /// </summary>
            public const string Link = "Link";

            /// <summary>
            /// The photo gallery
            /// </summary>
            public const string PhotoGallery = "Photo Gallery";
        }

        /// <summary>
        /// Photo Gallery Fields
        /// </summary>
        public struct PhotoGallery
        {
            /// <summary>
            /// The title
            /// </summary>
            public const string Title = "Title";
        }

        /// <summary>
        /// Photo Fields
        /// </summary>
        public struct Photo
        {
            /// <summary>
            /// The image
            /// </summary>
            public const string Image = "Image";

            /// <summary>
            /// The title
            /// </summary>
            public const string Title = "Title";

            /// <summary>
            /// The caption
            /// </summary>
            public const string Caption = "Caption";
        }

        /// <summary>
        /// Link List Fields
        /// </summary>
        public struct LinkList
        {
            /// <summary>
            /// The image
            /// </summary>
            public const string Image = "Image";

            /// <summary>
            /// The title
            /// </summary>
            public const string Title = "Title";

            /// <summary>
            /// The link1
            /// </summary>
            public const string Link1 = "Link 1";

            /// <summary>
            /// The link2
            /// </summary>
            public const string Link2 = "Link 2";

            /// <summary>
            /// The link3
            /// </summary>
            public const string Link3 = "Link 3";

            /// <summary>
            /// The link4
            /// </summary>
            public const string Link4 = "Link 4";

            /// <summary>
            /// The link5
            /// </summary>
            public const string Link5 = "Link 5";

            /// <summary>
            /// The link6
            /// </summary>
            public const string Link6 = "Link 6";

            /// <summary>
            /// The link7
            /// </summary>
            public const string Link7 = "Link 7";

            /// <summary>
            /// The link8
            /// </summary>
            public const string Link8 = "Link 8";

            /// <summary>
            /// The link9
            /// </summary>
            public const string Link9 = "Link 9";

            /// <summary>
            /// The link10
            /// </summary>
            public const string Link10 = "Link 10";

            /// <summary>
            /// The link11
            /// </summary>
            public const string Link11 = "Link 11";

            /// <summary>
            /// The link12
            /// </summary>
            public const string Link12 = "Link 12";

            /// <summary>
            /// The link13
            /// </summary>
            public const string Link13 = "Link 13";

            /// <summary>
            /// The link14
            /// </summary>
            public const string Link14 = "Link 14";

            /// <summary>
            /// The link15
            /// </summary>
            public const string Link15 = "Link 15";

            /// <summary>
            /// The link16
            /// </summary>
            public const string Link16 = "Link 16";

            /// <summary>
            /// The link17
            /// </summary>
            public const string Link17 = "Link 17";

            /// <summary>
            /// The link18
            /// </summary>
            public const string Link18 = "Link 18";

            /// <summary>
            /// The link19
            /// </summary>
            public const string Link19 = "Link 19";

            /// <summary>
            /// The link20
            /// </summary>
            public const string Link20 = "Link 20";
        }

        /// <summary>
        /// Related Content Types
        /// </summary>
        public struct RelatedContentTypes
        {
            /// <summary>
            /// The photo gallery
            /// </summary>
            public const string PhotoGallery = "{D237236D-83DF-4361-9B1A-9189FEC34536}";
        }

        /// <summary>
        /// Hospital Information Types
        /// </summary>
        public struct HospitalInformationTypes
        {
            /// <summary>
            /// The about the area
            /// </summary>
            public const string AboutTheArea = "{3286FE34-5FC2-4F14-B1EE-3DAF15E77D02}"; //"About the Area";

            /// <summary>
            /// The contacting a patient
            /// </summary>
            public const string ContactingAPatient = "{695ACC35-07F2-40A8-81A8-3D8C416DE2D5}"; //"Contacting a Patient";

            /// <summary>
            /// The hospital amenities and services
            /// </summary>
            public const string HospitalAmenitiesAndServices = "{14E003A1-A521-4916-9027-72C85115A0BB}"; //"Hospital Amenities and Services";

            /// <summary>
            /// The visiting and parking
            /// </summary>
            public const string VisitingAndParking = "{53166EAF-E24E-48E4-A414-47DA2FC36A67}"; //"Visiting and Parking";
        }

        /// <summary>
        /// Alert Pod Fields
        /// </summary>
        public struct AlertPod
        {
            /// <summary>
            /// The headline
            /// </summary>
            public const string Headline = "Headline";

            /// <summary>
            /// The body
            /// </summary>
            public const string Body = "Body";

            /// <summary>
            /// The call to action link
            /// </summary>
            public const string CallToActionLink = "Call To Action Link";
        }

        /// <summary>
        /// Announcement Pod Fields
        /// </summary>
        public struct AnnouncementPod
        {
            /// <summary>
            /// The headline
            /// </summary>
            public const string Headline = "Headline";

            /// <summary>
            /// The body
            /// </summary>
            public const string Body = "Body";

            /// <summary>
            /// The image
            /// </summary>
            public const string Image = "Image";

            /// <summary>
            /// The call to action link
            /// </summary>
            public const string CallToActionLink = "Call To Action Link";
        }

        /// <summary>
        /// Success Mode Types
        /// </summary>
        public struct SuccessModeTypes
        {
            /// <summary>
            /// The redirect
            /// </summary>
            public const string Redirect = "{F4D50806-6B89-4F2D-89FE-F77FC0A07D48}";

            /// <summary>
            /// The show message
            /// </summary>
            public const string ShowMessage = "{3B8369A0-CC1A-4E9A-A3DB-7B086379C53B}";
        }

        /// <summary>
        /// User Profile Types
        /// </summary>
        public struct UserProfileTypes
        {
            /// <summary>
            /// The user
            /// </summary>
            public const string User = "{AE4C4969-5B7E-4B4E-9042-B2D8701CE214}";

            /// <summary>
            /// The visitor profile
            /// </summary>
            public const string VisitorProfile = "{38F813E8-8787-4CE5-B13F-6D0C554E7927}";
        }


        /// <summary>
        /// Contact Us Custom Form Fields
        /// </summary>
        public struct ContactUsForm
        {
            /// <summary>
            /// The locations
            /// </summary>
            public const string Subjects = "Subjects";
        }

        /// <summary>
        /// Contact Us Subject Fields
        /// </summary>
        public struct ContactUsSubject
        {
            /// <summary>
            /// The dropdown title
            /// </summary>
            public const string DropdownTitle = "Dropdown Title";

            /// <summary>
            /// From address
            /// </summary>
            public const string FromAddress = "From Address";

            /// <summary>
            /// To addresses
            /// </summary>
            public const string ToAddresses = "To Addresses";

            /// <summary>
            /// The cc addresses
            /// </summary>
            public const string CcAddresses = "CC Addresses";

            /// <summary>
            /// The BCC addresses
            /// </summary>
            public const string BccAddresses = "BCC Addresses";

            /// <summary>
            /// The subject
            /// </summary>
            public const string Subject = "Subject";

            /// <summary>
            /// The success page
            /// </summary>
            public const string SuccessPage = "Success Page";
        }

        /// <summary>
        /// Clinical Research Department Fields
        /// </summary>
        public struct ClinicalResearchDepartment
        {
            /// <summary>
            /// The dropdown title
            /// </summary>
            public const string DropdownTitle = "Dropdown Title";

            /// <summary>
            /// From address
            /// </summary>
            public const string FromAddress = "From Address";

            /// <summary>
            /// To addresses
            /// </summary>
            public const string ToAddresses = "To Addresses";

            /// <summary>
            /// The cc addresses
            /// </summary>
            public const string CcAddresses = "CC Addresses";

            /// <summary>
            /// The BCC addresses
            /// </summary>
            public const string BccAddresses = "BCC Addresses";

            /// <summary>
            /// The subject
            /// </summary>
            public const string Subject = "Subject";
        }

        /// <summary>
        /// Custom Form Fields
        /// </summary>
        public struct CustomForm
        {
            /// <summary>
            /// The title
            /// </summary>
            public const string Title = "Title";

            /// <summary>
            /// The show title
            /// </summary>
            public const string ShowTitle = "Show Title";

            /// <summary>
            /// The introduction
            /// </summary>
            public const string Introduction = "Introduction";

            /// <summary>
            /// The show introduction
            /// </summary>
            public const string ShowIntroduction = "Show Introduction";

            /// <summary>
            /// The footer
            /// </summary>
            public const string Footer = "Footer";

            /// <summary>
            /// The show footer
            /// </summary>
            public const string ShowFooter = "Show Footer";

            /// <summary>
            /// The name
            /// </summary>
            public const string Name = "Name";

            /// <summary>
            /// The success mode
            /// </summary>
            public const string SuccessMode = "Success Mode";

            /// <summary>
            /// The success message
            /// </summary>
            public const string SuccessMessage = "Success Message";

            /// <summary>
            /// The success page
            /// </summary>
            public const string SuccessPage = "Success Page";

            /// <summary>
            /// The save action failed message
            /// </summary>
            public const string SaveActionFailedMessage = "Save Action Failed Message";

            /// <summary>
            /// The user profile
            /// </summary>
            public const string UserProfile = "User Profile";
        }

        /// <summary>
        /// Pre Anesthesia History Form Fields
        /// </summary>
        public struct PreAnesthesiaHistoryForm
        {
            /// <summary>
            /// The surgeons
            /// </summary>
            public const string Surgeons = "Surgeons";

            /// <summary>
            /// The consumer from address
            /// </summary>
            public const string ConsumerFromAddress = "Consumer From Address";

            /// <summary>
            /// The consumer email subject
            /// </summary>
            public const string ConsumerEmailSubject = "Consumer Email Subject";

            /// <summary>
            /// The consumer email body
            /// </summary>
            public const string ConsumerEmailBody = "Consumer Email Body";

            /// <summary>
            /// The marketing from address
            /// </summary>
            public const string MarketingFromAddress = "Marketing From Address";

            /// <summary>
            /// The marketing to addresses
            /// </summary>
            public const string MarketingToAddresses = "Marketing To Addresses";

            /// <summary>
            /// The marketing cc addresses
            /// </summary>
            public const string MarketingCCAddresses = "Marketing CC Addresses";

            /// <summary>
            /// The marketing BCC addresses
            /// </summary>
            public const string MarketingBCCAddresses = "Marketing BCC Addresses";

            /// <summary>
            /// The marketing email subject
            /// </summary>
            public const string MarketingEmailSubject = "Marketing Email Subject";
        }

        /// <summary>
        /// Single Email Only Form
        /// </summary>
        public struct SingleEmailOnlyForm
        {
            /// <summary>
            /// The marketing from address
            /// </summary>
            public const string MarketingFromAddress = "Marketing From Address";

            /// <summary>
            /// The marketing to addresses
            /// </summary>
            public const string MarketingToAddresses = "Marketing To Addresses";

            /// <summary>
            /// The marketing cc addresses
            /// </summary>
            public const string MarketingCCAddresses = "Marketing CC Addresses";

            /// <summary>
            /// The marketing BCC addresses
            /// </summary>
            public const string MarketingBCCAddresses = "Marketing BCC Addresses";

            /// <summary>
            /// The marketing email subject
            /// </summary>
            public const string MarketingEmailSubject = "Marketing Email Subject";
        }

        /// <summary>
        /// Neuro Psychology Referral Form
        /// </summary>
        public struct NeuroPsychologyReferralForm
        {
            /// <summary>
            /// The marketing from address
            /// </summary>
            public const string MarketingFromAddress = "Marketing From Address";

            /// <summary>
            /// The marketing to addresses
            /// </summary>
            public const string MarketingToAddresses = "Marketing To Addresses";

            /// <summary>
            /// The marketing cc addresses
            /// </summary>
            public const string MarketingCCAddresses = "Marketing CC Addresses";

            /// <summary>
            /// The marketing BCC addresses
            /// </summary>
            public const string MarketingBCCAddresses = "Marketing BCC Addresses";

            /// <summary>
            /// The marketing email subject
            /// </summary>
            public const string MarketingEmailSubject = "Marketing Email Subject";
        }

        /// <summary>
        /// Cranio Online Referral Form
        /// </summary>
        public struct CranioOnlineReferralForm
        {
            /// <summary>
            /// The marketing from address
            /// </summary>
            public const string MarketingFromAddress = "Marketing From Address";

            /// <summary>
            /// The marketing to addresses
            /// </summary>
            public const string MarketingToAddresses = "Marketing To Addresses";

            /// <summary>
            /// The marketing cc addresses
            /// </summary>
            public const string MarketingCCAddresses = "Marketing CC Addresses";

            /// <summary>
            /// The marketing BCC addresses
            /// </summary>
            public const string MarketingBCCAddresses = "Marketing BCC Addresses";

            /// <summary>
            /// The marketing email subject
            /// </summary>
            public const string MarketingEmailSubject = "Marketing Email Subject";
        }

        /// <summary>
        /// Cranio Online Referral Form
        /// </summary>
        public struct SportsMedicinePreregistrationForm
        {
            /// <summary>
            /// The marketing from address
            /// </summary>
            public const string MarketingFromAddress = "Marketing From Address";

            /// <summary>
            /// The marketing to addresses
            /// </summary>
            public const string MarketingToAddresses = "Marketing To Addresses";

            /// <summary>
            /// The marketing cc addresses
            /// </summary>
            public const string MarketingCCAddresses = "Marketing CC Addresses";

            /// <summary>
            /// The marketing BCC addresses
            /// </summary>
            public const string MarketingBCCAddresses = "Marketing BCC Addresses";

            /// <summary>
            /// The marketing email subject
            /// </summary>
            public const string MarketingEmailSubject = "Marketing Email Subject";
        }


        /// <summary>
        /// Volunteer Assessment Form Fields
        /// </summary>
        public struct VolunteerAssessmentForm
        {
            /// <summary>
            /// The locations
            /// </summary>
            public const string Locations = "Locations";
        }


        /// <summary>
        /// Volunteer Assessment Location
        /// </summary>
        public struct VolunteerAssessmentLocation
        {
            /// <summary>
            /// The dropdown title
            /// </summary>
            public const string DropdownTitle = "Dropdown Title";

            /// <summary>
            /// The success message
            /// </summary>
            public const string SuccessMessage = "Success Message";

            /// <summary>
            /// The location from address
            /// </summary>
            public const string LocationFromAddress = "Location From Address";

            /// <summary>
            /// The location to addresses
            /// </summary>
            public const string LocationToAddresses = "Location To Addresses";

            /// <summary>
            /// The location cc addresses
            /// </summary>
            public const string LocationCCAddresses = "Location CC Addresses";

            /// <summary>
            /// The location BCC addresses
            /// </summary>
            public const string LocationBCCAddresses = "Location BCC Addresses";

            /// <summary>
            /// The location subject
            /// </summary>
            public const string LocationSubject = "Location Subject";
        }

        /// <summary>
        /// Observation Form
        /// </summary>
        public struct ObservationForm
        {
            /// <summary>
            /// The redirect terms
            /// </summary>
            public const string RedirectTerms = "Redirect Terms";
        }

        /// <summary>
        /// Observation Redirect Term
        /// </summary>
        public struct ObservationRedirectTerm
        {
            /// <summary>
            /// The dropdown title
            /// </summary>
            public const string DropdownTitle = "Dropdown Title";

            /// <summary>
            /// The redirect URL
            /// </summary>
            public const string RedirectUrl = "Redirect Url";

            /// <summary>
            /// The marketing from address
            /// </summary>
            public const string MarketingFromAddress = "Marketing From Address";

            /// <summary>
            /// The marketing to addresses
            /// </summary>
            public const string MarketingToAddresses = "Marketing To Addresses";

            /// <summary>
            /// The marketing cc addresses
            /// </summary>
            public const string MarketingCCAddresses = "Marketing CC Addresses";

            /// <summary>
            /// The marketing BCC addresses
            /// </summary>
            public const string MarketingBCCAddresses = "Marketing BCC Addresses";

            /// <summary>
            /// The marketing subject
            /// </summary>
            public const string MarketingEmailSubject = "Marketing Email Subject";
        }

        /// <summary>
        /// CME Module Post Test Form
        /// </summary>
        public struct CMEModulePostTestForm
        {
            /// <summary>
            /// The marketing from address
            /// </summary>
            public const string MarketingFromAddress = "Marketing From Address";

            /// <summary>
            /// The marketing to addresses
            /// </summary>
            public const string MarketingToAddresses = "Marketing To Addresses";

            /// <summary>
            /// The marketing cc addresses
            /// </summary>
            public const string MarketingCCAddresses = "Marketing CC Addresses";

            /// <summary>
            /// The marketing BCC addresses
            /// </summary>
            public const string MarketingBCCAddresses = "Marketing BCC Addresses";

            /// <summary>
            /// The marketing email subject
            /// </summary>
            public const string MarketingEmailSubject = "Marketing Email Subject";

            /// <summary>
            /// The consumer from address
            /// </summary>
            public const string ConsumerFromAddress = "Consumer From Address";

            /// <summary>
            /// The consumer email subject
            /// </summary>
            public const string ConsumerEmailSubject = "Consumer Email Subject";
        }

        /// <summary>
        /// Surgey Scheduling Form Fields
        /// </summary>
        public struct SurgerySchedulingForm
        {
            /// <summary>
            /// The locations
            /// </summary>
            public const string Locations = "Locations";

            /// <summary>
            /// The consumer from address
            /// </summary>
            public const string ConsumerFromAddress = "Consumer From Address";

            /// <summary>
            /// The consumer email subject
            /// </summary>
            public const string ConsumerEmailSubject = "Consumer Email Subject";

            /// <summary>
            /// The consumer email body
            /// </summary>
            public const string ConsumerEmailBody = "Consumer Email Body";

            /// <summary>
            /// The marketing from address
            /// </summary>
            public const string MarketingFromAddress = "Marketing From Address";

            /// <summary>
            /// The marketing to addresses
            /// </summary>
            public const string MarketingToAddresses = "Marketing To Addresses";

            /// <summary>
            /// The marketing cc addresses
            /// </summary>
            public const string MarketingCCAddresses = "Marketing CC Addresses";

            /// <summary>
            /// The marketing BCC addresses
            /// </summary>
            public const string MarketingBCCAddresses = "Marketing BCC Addresses";

            /// <summary>
            /// The marketing email subject
            /// </summary>
            public const string MarketingEmailSubject = "Marketing Email Subject";
        }


        /// <summary>
        /// Radiology Presedation Form
        /// </summary>
        public struct RadiologyPresedationForm
        {
            /// <summary>
            /// The locations
            /// </summary>
            public const string Locations = "Locations";

            /// <summary>
            /// The consumer from address
            /// </summary>
            public const string ConsumerFromAddress = "Consumer From Address";

            /// <summary>
            /// The consumer email subject
            /// </summary>
            public const string ConsumerEmailSubject = "Consumer Email Subject";

            /// <summary>
            /// The consumer email body
            /// </summary>
            public const string ConsumerEmailBody = "Consumer Email Body";
        }

        /// <summary>
        /// Radiology Presedation Location
        /// </summary>
        public struct RadiologyPresedationLocation
        {
            /// <summary>
            /// The dropdown title
            /// </summary>
            public const string DropdownTitle = "Dropdown Title";

            /// <summary>
            /// The location from address
            /// </summary>
            public const string LocationFromAddress = "Location From Address";

            /// <summary>
            /// The location to addresses
            /// </summary>
            public const string LocationToAddresses = "Location To Addresses";

            /// <summary>
            /// The location cc addresses
            /// </summary>
            public const string LocationCCAddresses = "Location CC Addresses";

            /// <summary>
            /// The location BCC addresses
            /// </summary>
            public const string LocationBCCAddresses = "Location BCC Addresses";

            /// <summary>
            /// The location subject
            /// </summary>
            public const string LocationSubject = "Location Subject";
        }

        /// <summary>
        /// Rehabilitation Request An Appointment Form Fields
        /// </summary>
        public struct RehabilitationRequestAnAppointmentForm
        {
            /// <summary>
            /// The language
            /// </summary>
            public const string Language = "Language";

            /// <summary>
            /// The marketing from address
            /// </summary>
            public const string MarketingFromAddress = "Marketing From Address";

            /// <summary>
            /// The marketing to addresses
            /// </summary>
            public const string MarketingToAddresses = "Marketing To Addresses";

            /// <summary>
            /// The marketing cc addresses
            /// </summary>
            public const string MarketingCCAddresses = "Marketing CC Addresses";

            /// <summary>
            /// The marketing BCC addresses
            /// </summary>
            public const string MarketingBCCAddresses = "Marketing BCC Addresses";

            /// <summary>
            /// The marketing email subject
            /// </summary>
            public const string MarketingEmailSubject = "Marketing Email Subject";
        }

        /// <summary>
        /// Patient Family Questionnaire Fields
        /// </summary>
        public struct PatientFamilyQuestionnaire
        {
            /// <summary>
            /// The consumer from address
            /// </summary>
            public const string ConsumerFromAddress = "Consumer From Address";

            /// <summary>
            /// The consumer email subject
            /// </summary>
            public const string ConsumerEmailSubject = "Consumer Email Subject";

            /// <summary>
            /// The consumer email body
            /// </summary>
            public const string ConsumerEmailBody = "Consumer Email Body";

            /// <summary>
            /// The marketing from address
            /// </summary>
            public const string MarketingFromAddress = "Marketing From Address";

            /// <summary>
            /// The marketing to addresses
            /// </summary>
            public const string MarketingToAddresses = "Marketing To Addresses";

            /// <summary>
            /// The marketing cc addresses
            /// </summary>
            public const string MarketingCCAddresses = "Marketing CC Addresses";

            /// <summary>
            /// The marketing BCC addresses
            /// </summary>
            public const string MarketingBCCAddresses = "Marketing BCC Addresses";

            /// <summary>
            /// The marketing email subject
            /// </summary>
            public const string MarketingEmailSubject = "Marketing Email Subject";
        }



        /// <summary>
        /// Share Your Story Form Fields
        /// </summary>
        public struct ShareYourStoryForm
        {
            /// <summary>
            /// The consumer from address
            /// </summary>
            public const string ConsumerFromAddress = "Consumer From Address";

            /// <summary>
            /// The consumer email subject
            /// </summary>
            public const string ConsumerEmailSubject = "Consumer Email Subject";

            /// <summary>
            /// The consumer email body
            /// </summary>
            public const string ConsumerEmailBody = "Consumer Email Body";

            /// <summary>
            /// The marketing from address
            /// </summary>
            public const string MarketingFromAddress = "Marketing From Address";

            /// <summary>
            /// The marketing to addresses
            /// </summary>
            public const string MarketingToAddresses = "Marketing To Addresses";

            /// <summary>
            /// The marketing cc addresses
            /// </summary>
            public const string MarketingCCAddresses = "Marketing CC Addresses";

            /// <summary>
            /// The marketing BCC addresses
            /// </summary>
            public const string MarketingBCCAddresses = "Marketing BCC Addresses";

            /// <summary>
            /// The marketing email subject
            /// </summary>
            public const string MarketingEmailSubject = "Marketing Email Subject";
        }



        /// <summary>
        /// Diaversary Form Fields
        /// </summary>
        public struct DiaversaryForm
        {
            /// <summary>
            /// The consumer from address
            /// </summary>
            public const string ConsumerFromAddress = "Consumer From Address";

            /// <summary>
            /// The consumer email subject
            /// </summary>
            public const string ConsumerEmailSubject = "Consumer Email Subject";

            /// <summary>
            /// The consumer email body
            /// </summary>
            public const string ConsumerEmailBody = "Consumer Email Body";

            /// <summary>
            /// The marketing from address
            /// </summary>
            public const string MarketingFromAddress = "Marketing From Address";

            /// <summary>
            /// The marketing to addresses
            /// </summary>
            public const string MarketingToAddresses = "Marketing To Addresses";

            /// <summary>
            /// The marketing cc addresses
            /// </summary>
            public const string MarketingCCAddresses = "Marketing CC Addresses";

            /// <summary>
            /// The marketing BCC addresses
            /// </summary>
            public const string MarketingBCCAddresses = "Marketing BCC Addresses";

            /// <summary>
            /// The marketing email subject
            /// </summary>
            public const string MarketingEmailSubject = "Marketing Email Subject";
        }


        /// <summary>
        /// CPGReferral Form Fields
        /// </summary>
        public struct CPGReferralForm
        {
            /// <summary>
            /// The surgeons
            /// </summary>
            public const string CPGSpecialties = "Specialties";

            /// <summary>
            /// The consumer from address
            /// </summary>
            public const string ConsumerFromAddress = "Consumer From Address";

            /// <summary>
            /// The consumer email subject
            /// </summary>
            public const string ConsumerEmailSubject = "Consumer Email Subject";

            /// <summary>
            /// The consumer email body
            /// </summary>
            public const string ConsumerEmailBody = "Consumer Email Body";

            /// <summary>
            /// The marketing from address
            /// </summary>
            public const string MarketingFromAddress = "Marketing From Address";

            /// <summary>
            /// The marketing to addresses
            /// </summary>
            public const string MarketingToAddresses = "Marketing To Addresses";

            /// <summary>
            /// The marketing cc addresses
            /// </summary>
            public const string MarketingCCAddresses = "Marketing CC Addresses";

            /// <summary>
            /// The marketing BCC addresses
            /// </summary>
            public const string MarketingBCCAddresses = "Marketing BCC Addresses";

            /// <summary>
            /// The marketing email subject
            /// </summary>
            public const string MarketingEmailSubject = "Marketing Email Subject";
        }


        /// <summary>
        /// Sibley Heart Center Cardiology Provider Referral Form Fields
        /// </summary>
        public struct SibleyReferralForm
        {
            /// <summary>
            /// The surgeons
            /// </summary>
            public const string SibleySpecialties = "Specialties";

            /// <summary>
            /// The consumer from address
            /// </summary>
            public const string ConsumerFromAddress = "Consumer From Address";

            /// <summary>
            /// The consumer email subject
            /// </summary>
            public const string ConsumerEmailSubject = "Consumer Email Subject";

            /// <summary>
            /// The consumer email body
            /// </summary>
            public const string ConsumerEmailBody = "Consumer Email Body";

            /// <summary>
            /// The marketing from address
            /// </summary>
            public const string MarketingFromAddress = "Marketing From Address";

            /// <summary>
            /// The marketing to addresses
            /// </summary>
            public const string MarketingToAddresses = "Marketing To Addresses";

            /// <summary>
            /// The marketing cc addresses
            /// </summary>
            public const string MarketingCCAddresses = "Marketing CC Addresses";

            /// <summary>
            /// The marketing BCC addresses
            /// </summary>
            public const string MarketingBCCAddresses = "Marketing BCC Addresses";

            /// <summary>
            /// The marketing email subject
            /// </summary>
            public const string MarketingEmailSubject = "Marketing Email Subject";
        }

        /// <summary>
        /// Specialty Fields - For Sibley Referral Form
        /// </summary>
        public struct SibleySpecialty
        {
            /// <summary>
            /// The specialty name
            /// </summary>
            public const string SpecialtyName = "Specialty Name";
        }


        /// <summary>
        /// Online Sponsorship Form Fields
        /// </summary>
        public struct OnlineSponsorshipForm
        {
            /// <summary>
            /// The consumer from address
            /// </summary>
            public const string ConsumerFromAddress = "Consumer From Address";

            /// <summary>
            /// The consumer email subject
            /// </summary>
            public const string ConsumerEmailSubject = "Consumer Email Subject";

            /// <summary>
            /// The consumer email body
            /// </summary>
            public const string ConsumerEmailBody = "Consumer Email Body";

            /// <summary>
            /// The marketing from address
            /// </summary>
            public const string MarketingFromAddress = "Marketing From Address";

            /// <summary>
            /// The marketing to addresses
            /// </summary>
            public const string MarketingToAddresses = "Marketing To Addresses";

            /// <summary>
            /// The marketing cc addresses
            /// </summary>
            public const string MarketingCCAddresses = "Marketing CC Addresses";

            /// <summary>
            /// The marketing BCC addresses
            /// </summary>
            public const string MarketingBCCAddresses = "Marketing BCC Addresses";

            /// <summary>
            /// The marketing email subject
            /// </summary>
            public const string MarketingEmailSubject = "Marketing Email Subject";
        }


        /// <summary>
        /// Surgeon Fields
        /// </summary>
        public struct Surgeon
        {
            /// <summary>
            /// The surgeon name
            /// </summary>
            public const string SurgeonName = "Surgeon Name";
        }

        /// <summary>
        /// Surgery Location Fields
        /// </summary>
        public struct SurgeryLocation
        {
            /// <summary>
            /// The dropdown title
            /// </summary>
            public const string DropdownTitle = "Dropdown Title";

            /// <summary>
            /// The location from address
            /// </summary>
            public const string LocationFromAddress = "Location From Address";

            /// <summary>
            /// The location to addresses
            /// </summary>
            public const string LocationToAddresses = "Location To Addresses";

            /// <summary>
            /// The location cc addresses
            /// </summary>
            public const string LocationCCAddresses = "Location CC Addresses";

            /// <summary>
            /// The location BCC addresses
            /// </summary>
            public const string LocationBCCAddresses = "Location BCC Addresses";

            /// <summary>
            /// The location subject
            /// </summary>
            public const string LocationSubject = "Location Subject";

            /// <summary>
            /// The reminder from address
            /// </summary>
            public const string ReminderFromAddress = "Reminder From Address";

            /// <summary>
            /// The reminder to addresses
            /// </summary>
            public const string ReminderToAddresses = "Reminder To Addresses";

            /// <summary>
            /// The reminder cc addresses
            /// </summary>
            public const string ReminderCCAddresses = "Reminder CC Addresses";

            /// <summary>
            /// The reminder BCC addresses
            /// </summary>
            public const string ReminderBCCAddresses = "Reminder BCC Addresses";

            /// <summary>
            /// The reminder subject
            /// </summary>
            public const string ReminderSubject = "Reminder Subject";

            /// <summary>
            /// The send reminder email
            /// </summary>
            public const string SendReminderEmail = "Send Reminder Email";
        }

        /// <summary>
        /// Wait Times Page Fields
        /// </summary>
        public struct WaitTimesPage
        {
            /// <summary>
            /// The section title
            /// </summary>
            public const string SectionTitle = "Section Title";

            /// <summary>
            /// The emergency section title
            /// </summary>
            public const string EmergencySectionTitle = "Emergency Section Title";

            /// <summary>
            /// The emergency section body
            /// </summary>
            public const string EmergencySectionBody = "Emergency Section Body";

            /// <summary>
            /// The urgent care section title
            /// </summary>
            public const string UrgentCareSectionTitle = "Urgent Care Section Title";

            /// <summary>
            /// The urgent care section body
            /// </summary>
            public const string UrgentCareSectionBody = "Urgent Care Section Body";
        }

        /// <summary>
        /// Search Settings Fields
        /// </summary>
        public struct SearchSettings
        {
            /// <summary>
            /// The default search results page
            /// </summary>
            public const string DefaultSearchResultsPage = "Default Search Results Page";

            public const string SecondarySearchResultsPage = "Secondary Search Results Page";

            /// <summary>
            /// The search tabs
            /// </summary>
            public const string SearchTabs = "Search Tabs";

            /// <summary>
            /// The no search results found message
            /// </summary>
            public const string NoSearchResultsFoundMessage = "No Search Results Found Message";

            /// <summary>
            /// Media Search Root Path
            /// </summary>
            public const string MediaSearchRoot = "Media Search Root";
        }

        /// <summary>
        /// Search Tab Fields
        /// </summary>
        public struct SearchTab
        {
            /// <summary>
            /// The title
            /// </summary>
            public const string Title = "Title";

            /// <summary>
            /// The search results page
            /// </summary>
            public const string SearchResultsPage = "Search Results Page";

            /// <summary>
            /// The page type
            /// </summary>
            public const string PageType = "Page Type";
        }

        /// <summary>
        /// Site Settings Fields
        /// </summary>
        public struct SiteSettings
        {
            /// <summary>
            /// The page title suffix
            /// </summary>
            public const string PageTitleSuffix = "Page Title Suffix";

            /// <summary>
            /// The desktop site logo
            /// </summary>
            public const string DesktopSiteLogo = "Desktop Site Logo";

            /// <summary>
            /// The mobile site logo
            /// </summary>
            public const string MobileSiteLogo = "Mobile Site Logo";

            /// <summary>
            /// The primary navigation
            /// </summary>
            public const string PrimaryNavigation = "Primary Navigation";

            /// <summary>
            /// The utility navigation
            /// </summary>
            public const string UtilityNavigation = "Utility Navigation";

            /// <summary>
            /// The social connections
            /// </summary>
            public const string SocialConnections = "Social Connections";

            /// <summary>
            /// The contact us methods
            /// </summary>
            public const string ContactUsMethods = "Contact Us Methods";

            /// <summary>
            /// The column1 links
            /// </summary>
            public const string Column1Links = "Column 1 Links";

            /// <summary>
            /// The column2 links
            /// </summary>
            public const string Column2Links = "Column 2 Links";

            /// <summary>
            /// The column3 links
            /// </summary>
            public const string Column3Links = "Column 3 Links";

            /// <summary>
            /// The awards
            /// </summary>
            public const string Awards = "Awards";

            /// <summary>
            /// The terms of use
            /// </summary>
            public const string TermsOfUse = "Terms Of Use";

            /// <summary>
            /// The patient privacy
            /// </summary>
            public const string PatientPrivacy = "Patient Privacy";

            /// <summary>
            /// The Statement Of Discrimination
            /// </summary>
            public const string StatementOfDiscrimination = "Statement Of Discrimination";

            /// <summary>
            /// The copyright
            /// </summary>
            public const string Copyright = "Copyright";

            /// <summary>
            /// The page not found
            /// </summary>
            public const string PageNotFound = "Page Not Found";

            /// <summary>
            /// The google analytics identifier
            /// </summary>
            public const string GoogleAnalyticsId = "Google Analytics Id";

            /// <summary>
            /// Default download image
            /// </summary>
            public const string DownloadImage = "Download Image";

            /// <summary>
            /// Default Contact Us
            /// </summary>
            public const string ContactUs = "Contact Us";

            public const string ScriptSource = "Script Source";

            /// <summary>
            /// The link pod column1 links
            /// </summary>
            public const string LinkPodLinksColumn1 = "Link Pod Links Column 1";

            /// <summary>
            /// The link pod column2 links
            /// </summary>
            public const string LinkPodLinksColumn2 = "Link Pod Links Column 2";

            /// <summary>
            /// Secondary Header Fields
            /// </summary>
            public const string SecondaryDesktopSiteLogo = "Secondary Desktop Site Logo";
            public const string SecondaryMobileSiteLogo = "Secondary Mobile Site Logo";
            public const string SecondaryPrimaryNavigation = "Secondary Primary Navigation";
            public const string SecondaryUtilityNavigation = "Secondary Utility Navigation";
            public const string Careers = "Careers";
            public const string Donate = "Donate";
            public const string WantTo = "Want To";
            public const string WantToLinks = "Want To Links";
            public const string SearchPlaceholder = "Search Placeholder";
            public const string SearchPlaceholderMobile = "Search Placeholder Mobile";
            public const string AlertEnabled = "Alert Enabled";
            public const string AlertTitle = "Alert Title";
            public const string AlertBarColor = "Alert Bar Color";
            public const string AlertHeadlineTitle = "Alert Headline Title";
            public const string AlertShowIcon = "Alert Show Icon";
            public const string AlertCopy = "Alert Copy";
            public const string AlertsLinks = "Alerts Links";

            /// <summary>
            /// Secondary Footer Fields
            /// </summary>
            public const string SecondarySocialConnections = "Secondary Social Connections";
            public const string SecondaryContactUsMethods = "Secondary Contact Us Methods";
            public const string SecondaryColumn1Links = "Secondary Column 1 Links";
            public const string SecondaryColumn2Links = "Secondary Column 2 Links";
            public const string SecondaryColumn3Links = "Secondary Column 3 Links";
            public const string SecondaryAwards = "Secondary Awards";
            public const string SecondaryTermsOfUse = "Secondary Terms Of Use";
            public const string SecondaryPatientPrivacy = "Secondary Patient Privacy";
            public const string SecondaryCopyright = "Secondary Copyright";
            public const string SecondaryStatementOfDiscrimination = "Secondary Statement Of Discrimination";

        }


        /// <summary>
        /// Specialty Fields - For CPG Referral Form
        /// </summary>
        public struct CPGSpecialty
        {
            /// <summary>
            /// The specialty name
            /// </summary>
            public const string SpecialtyName = "Specialty Name";
        }


        /// <summary>
        /// Concussion PopUp Fields Info
        /// </summary>
        public struct ConcussionPopUp
        {
            /// <summary>
            /// The title
            /// </summary>
            public const string Title = "Title";

            /// <summary>
            /// The license agreement text
            /// </summary>
            public const string LicenseAgreementText = "License Agreement Text";

            /// <summary>
            /// The english pdf
            /// </summary>
            public const string EnglishLink = "English PDF Link";

            /// <summary>
            /// The spanish pdf
            /// </summary>
            public const string SpanishLink = "Spanish PDF Link";

            /// <summary>
            /// The terms agreement acceptance
            /// </summary>
            public const string TermsAcceptance = "Terms of Agreement Acceptance";
        }


        public struct BlogDetails
        {
            public const string Title = "Blog Title";

            public const string BlogDescription = "Blog Description"; // New field is added

            public const string Description = "Description";

            public const string BlogPanelTitle = "Blog Panel Title";

            public const string Row1Text = "Row 1 Text";

            public const string ContentComponent = "Content Components";

            public const string Row3Text = "Row 3 Text";

            public const string RelatedArticles = "Related Articles";

            //public const string FeatureStoryTeaser = "Feature Story Teaser";

            //public const string FeatureStoryImage = "Feature Story Image";

            public const string DefaultArticleImage = "Default Article Image";

            public const string DefaultArticleLink = "Redirect Link";

            //public const string RelatedArticleImage = "Related Article Image";

            public const string BlogDate = "Blog Date";

        }

        public struct PhotoFrame
        {
            public const string PhotoFrameText = "Photo Frame Text";

            public const string PhotoFrameImage = "Photo Frame Image";
        }

        public struct BioProfile
        {
            public const string Name = "Name";

            public const string Title = "Title";

            public const string OrganizationName = "Organization Name";

            public const string Email = "Email";

            public const string Picture = "Picture";
        }


        public struct RelatedArticle
        {
            public const string ArticleTitle = "Article Title";

            public const string ArticleDescription = "Article Description";

            public const string ArticleImage = "Article Image";

            public const string ArticlePagePath = "Redirect Link";
        }

        public struct BlogLanding
        {
            public const string FeaturedStory = "Featured Story";

            public const string FeatureStoryTeaser = "Featured Story Teaser";

            public const string DefaultStories = "Default Stories";

            public const string LoadMoreCount = "Load More Count";

            public const string ReadMoreText = "Read More Text";

            public const string PopularPosts = "Popular Posts";

        }

        public struct ParentResourceLanding
        {
            public const string LandingFeaturedStory = "Landing Page Featured Stories";

            public const string LandingSubStories = "Landing Page Sub Stories";

            public const string AgeLandingStories = "Age Sub Stories";

            public const string S4LResources = "S4L Resources";

            public const string LoadMoreCount = "Load More Count";
        }

        public struct ParentResourceDetails
        {
            public const string Title = "Title";

            public const string Description = "Description";

            public const string AgeTags = "Age Tags";

            public const string TopicTags = "Topic Tags";

            public const string StoryTitle = "Title Text";

            public const string PanelTitle = "Panel Title Text";

            public const string PublishedDate = "Parent Resource Published Date";

            public const string Row1Text = "Row 1 Text";

            public const string ContentComponents = "Content Components";

            public const string Row3Text = "Row 3 Text";

            public const string RelatedArticles = "Related Articles";

            public const string RelatedArticleImage = "Related Article Image";

            public const string FeatureStoryImage = "Feature Story Image";

            public const string FeatureStoryTeaser = "Feature Story Teaser";

            public const string SubStoryImage = "Sub Story Image";
        }


        public struct MicrositeHome
        {
            public const string Title = "Title";

            public const string Description = "Description";

            public const string Components = "Components";

            public const string ActionLinks = "Action Links";

            public const string MapInfo = "Map";
        }

        public struct MicrositeComponent
        {
            public const string Title = "Title";

            public const string Description = "Description";

            public const string Components = "Components";
        }

        public struct FacilitiesHome
        {
            public const string SecondaryNav = "Secondary Nav";

            public const string NavText = "Nav Text";

            public const string ScrollToClass = "Scroll To Class";
        }

        public struct Mantle
        {
            public const string Image = "Background Image";

            public const string WatchLive = "Watch Our Progress";
        }

        public struct MicrositeVideo
        {
            public const string Image = "Image";

            public const string VideoLink = "Video Link";
        }

        public struct FacilityGroup
        {
            public const string Facilities = "Facilities";
        }

        public struct Facility
        {
            public const string Title = "Title";

            public const string Description = "Description";

            public const string Image = "Image";

            public const string LearnMoreUrl = "Learn More Url";

            public const string ColorClass = "Color Class";
        }


        public struct MicrositeNewsEventsDetailsPage
        {
            /// <summary>
            /// The title
            /// </summary>
            public const string Title = "Title";

            /// <summary>
            /// The hero text component
            /// </summary>
            public const string HeroTextComponent = "Hero Text Component";

            /// <summary>
            /// The introduction text
            /// </summary>
            public const string IntroductionText = "Introduction Text";

            /// <summary>
            /// The content components
            /// </summary>
            public const string ContentComponents = "Content Components";

            /// <summary>
            /// The title
            /// </summary>
            public const string NewsMediaDate = "News Media Date";

            /// <summary>
            /// The content components
            /// </summary>
            public const string NewsMediaComponent = "News Media Component";

            /// <summary>
            /// The news image
            /// </summary>
            public const string NewsImage = "News Image";

            /// <summary>
            /// The title
            /// </summary>
            public const string NewsMediaCaption = "News Media Caption";

            /// <summary>
            /// The contacts
            /// </summary>
            public const string Contacts = "Contacts";

            /// <summary>
            /// The boilerplates
            /// </summary>
            public const string Boilerplates = "Boilerplates";

            /// <summary>
            /// The affiliate boilerplate
            /// </summary>
            public const string AffiliateBoilerplate = "Affiliate Boilerplate";

            /// <summary>
            /// The affiliate name
            /// </summary>
            public const string AffiliateName = "Affiliate Name";

            /// <summary>
            /// The affiliate link
            /// </summary>
            public const string AffiliateLink = "Affiliate Link";

            /// <summary>
            /// The affiliate logo
            /// </summary>
            public const string AffiliateLogo = "Affiliate Logo";

        }


        public struct MicrositeNewsEventsHeroDetails
        {
            /// <summary>
            /// The main header
            /// </summary>
            public const string MainHeader = "Main Header";

            /// <summary>
            /// The sub header
            /// </summary>
            public const string SubHeader = "Sub Header";

            /// <summary>
            /// The event date
            /// </summary>
            public const string EventDate = "Event Date";

            /// <summary>
            /// The event location name
            /// </summary>
            public const string EventLocationName = "Event Location Name";

            /// <summary>
            /// The all news events link text
            /// </summary>
            public const string NewsEventsLinkText = "All News Events Link Text";

            /// <summary>
            /// The all news events link
            /// </summary>
            public const string NewsEventsLink = "All News Events Link";

        }


        public struct MicrositeNewsEventsLandingPage
        {
            /// <summary>
            /// The title
            /// </summary>
            public const string Title = "Title";

            /// <summary>
            /// The hero text component
            /// </summary>
            public const string HeroTextComponent = "Hero Text Component";
        }


        public struct MicrositeNewsEventsArticleDetails
        {
            /// <summary>
            /// The article title
            /// </summary>
            public const string ArticleTitle = "Article Title";

            /// <summary>
            /// The article date
            /// </summary>
            public const string ArticleDate = "Article Date";

            /// <summary>
            /// The article blurb
            /// </summary>
            public const string ArticleBlurb = "Article Blurb";

            /// <summary>
            /// The article link
            /// </summary>
            public const string ArticleLink = "Article Link";
        }


        public struct MicrositeStayInformedLandingPage
        {
            /// <summary>
            /// The hero text component
            /// </summary>
            public const string HeroTextComponent = "Hero Text Component";

            /// <summary>
            /// The title
            /// </summary>
            public const string Title = "Title";

            /// <summary>
            /// The description
            /// </summary>
            public const string Description = "Description";

            /// <summary>
            /// The content components
            /// </summary>
            public const string ContentComponents = "Content Components";

            /// <summary>
            /// The meeting link
            /// </summary>
            public const string EventsMeetingsLink = "All Events Meetings Link";


        }


        public struct MicrositeNewsEventsMeetingDetails
        {
            /// <summary>
            /// The meeting title
            /// </summary>
            public const string MeetingTitle = "Meeting Title";

            /// <summary>
            /// The meeting date
            /// </summary>
            public const string MeetingDate = "Meeting Date";

            /// <summary>
            /// The meeting loccation
            /// </summary>
            public const string MeetingLocation = "Meeting Location";

            /// <summary>
            /// The meeting link
            /// </summary>
            public const string MeetingLink = "Meeting Link";
        }


        public struct MicrositeStayInformedSignUpDetails
        {
            /// <summary>
            /// The title
            /// </summary>
            public const string Title = "Title";

            /// <summary>
            /// The description
            /// </summary>
            public const string Description = "Description";

            /// <summary>
            /// The sign up link
            /// </summary>
            public const string SignUpLink = "Sign Up Link";
        }




        public struct Navigation
        {
            public const string Link = "Redirect Link";
        }

        public struct ActionLinks
        {
            public const string Text = "Link Text";

            public const string LinkType = "Link Type";

            public const string LinkUrl = "Link Url";

            public const string Title = "Title";
        }


        public struct Testimonial
        {
            public const string FamilyImage = "Family Image";

            public const string QuoteImage = "Quote Image";
        }

        public struct Slider
        {
            public const string Image = "Image";

            public const string Caption = "Caption";
        }

        public struct NamingOpportunity
        {
            public const string DonationList = "Opportunities Available List";

            public const string Title = "Title";

            public const string FloorList = "Floor List";

            public const string FloorName = "Floor Name";
        }


        /// <summary>
        /// Infographic Carousel Fields with Larger Image and Description
        /// </summary>
        public struct InfographicCarouselLgImgDesc
        {
            /// <summary>
            /// The image
            /// </summary>
            public const string Image = "Image";

            /// <summary>
            /// The title
            /// </summary>
            public const string Title = "Title";

            /// <summary>
            /// The title
            /// </summary>
            public const string TitleClass = "Title Class";

            /// <summary>
            /// The description
            /// </summary>
            public const string Description = "Description";
        }

        /// <summary>
        /// Infographic fields with Larger Image and Description
        /// </summary>
        public struct InfographicLgImgDesc
        {
            /// <summary>
            /// The image
            /// </summary>
            public const string Image = "Image";

            /// <summary>
            /// The title
            /// </summary>
            public const string Title = "Title";

            /// <summary>
            /// The title
            /// </summary>
            public const string TitleClass = "Title Class";

            /// <summary>
            /// The description
            /// </summary>
            public const string Description = "Description";
        }

        /// <summary>
        /// Icon pod for home page
        /// </summary>
        public struct IconPod
        {
            /// <summary>
            /// title
            /// </summary>
            public const string Title = "Title";

            /// <summary>
            /// description
            /// </summary>
            public const string Description = "Description";

            /// <summary>
            /// redirect
            /// </summary>
            public const string Redirect = "Redirect";

            /// <summary>
            /// icon color
            /// </summary>
            public const string IconColor = "Icon Color";

            /// <summary>
            /// icon class
            /// </summary>
            public const string IconClass = "Icon Class";
        }

        /// <summary>
        /// Icon pod for home page
        /// </summary>
        public struct ArticlePod
        {
            /// <summary>
            /// title
            /// </summary>
            public const string LinkText = "Link Text";

            /// <summary>
            /// description
            /// </summary>
            public const string LinkUrl = "Link Url";

            /// <summary>
            /// redirect
            /// </summary>
            public const string ImageUrl = "Background Image";

            /// <summary>
            /// icon color
            /// </summary>
            public const string Decription = "Decription";

            /// <summary>
            /// icon class
            /// </summary>
            public const string ThemeColor = "Theme Color";

            /// <summary>
            /// icon class
            /// </summary>
            public const string BtnText = "Btn Text";

            /// <summary>
            /// icon class
            /// </summary>
            public const string BtnLink = "Btn Link";
        }


        /// <summary>
        /// Icon pod for home page
        /// </summary>
        public struct LandingPod
        {
            /// <summary>
            /// title
            /// </summary>
            public const string Title = "Title";

            /// <summary>
            /// description
            /// </summary>
            public const string Description = "Description";

            /// <summary>
            /// redirect
            /// </summary>
            public const string IconClass = "Icon Class";

            /// <summary>
            /// icon color
            /// </summary>
            public const string ThemeColor = "Theme Color";

            /// <summary>
            /// icon color
            /// </summary>
            public const string Redirect = "Redirect";
        }

        /// <summary>
        /// Doctor Item
        /// </summary>
        public struct Doctor
        {
            /// <summary>
            /// Cactus Id
            /// </summary>
            public const string CactusId = "CactusId";

            /// <summary>
            /// CactusIdHash
            /// </summary>
            public const string CactusIdHash = "CactusIdHash";

            /// <summary>
            /// First Name
            /// </summary>
            public const string FirstName = "First Name";

            /// <summary>
            /// Middle Name
            /// </summary>
            public const string MiddleName = "Middle Name";

            /// <summary>
            /// Last Name
            /// </summary>
            public const string LastName = "Last Name";

            /// <summary>
            /// Profile Bio
            /// </summary>
            public const string ProfileBio = "Profile Bio";

            /// <summary>
            /// PubMed Link
            /// </summary>
            public const string PubMedLink = "PubMed Link";

            /// <summary>
            /// Faculty Appointment
            /// </summary>
            public const string FacultyAppointment = "Faculty Appointment";

            /// <summary>
            /// Research Interests
            /// </summary>
            public const string ResearchInterests = "Research Interests";

            /// <summary>
            /// Video Link
            /// </summary>
            public const string VideoLink = "Video Link";

            /// <summary>
            /// The Video Poster Image
            /// </summary>
            public const string VideoPosterImage = "Video Poster Image";

            /// <summary>
            /// Video Publish Datek
            /// </summary>
            public const string VideoPublishDate = "Video Publish Date";

            /// <summary>
            /// Video Title
            /// </summary>
            public const string VideoTitle = "Video Title";

            /// <summary>
            /// Video Title Link
            /// </summary>
            public const string VideoTitleLink = "Video Title Link";

            /// <summary>
            /// Video Text
            /// </summary>
            public const string VideoText = "Video Text";

            /// <summary>
            /// Video Publisher Name
            /// </summary>
            public const string VideoPublisherName = "Video Publisher Name";

            /// <summary>
            /// Leadership Title 1
            /// </summary>
            public const string LeadershipTitle1 = "Leadership Title 1";

            /// <summary>
            /// Leadership Title 2
            /// </summary>
            public const string LeadershipTitle2 = "Leadership Title 2";

            /// <summary>
            /// Leadership Title 3
            /// </summary>
            public const string LeadershipTitle3 = "Leadership Title 3";

            /// <summary>
            /// Focus Of Practice 1
            /// </summary>
            public const string FocusOfPractice1 = "Focus Of Practice 1";

            /// <summary>
            /// Focus Of Practice 2
            /// </summary>
            public const string FocusOfPractice2 = "Focus Of Practice 2";

            /// <summary>
            /// Focus Of Practice 3
            /// </summary>
            public const string FocusOfPractice3 = "Focus Of Practice 3";

            /// <summary>
            /// Area Of Interest 1
            /// </summary>
            public const string AreaOfInterest1 = "Area Of Interest 1";

            /// <summary>
            /// Area Of Interest 2
            /// </summary>
            public const string AreaOfInterest2 = "Area Of Interest 2";

            /// <summary>
            /// Area Of Interest 3
            /// </summary>
            public const string AreaOfInterest3 = "Area Of Interest 3";

            /// <summary>
            /// Area Of Interest 4
            /// </summary>
            public const string AreaOfInterest4 = "Area Of Interest 4";

            /// <summary>
            /// Area Of Interest 5
            /// </summary>
            public const string AreaOfInterest5 = "Area Of Interest 5";

            /// <summary>
            /// Professional Affiliation 1
            /// </summary>
            public const string ProfessionalAffiliation1 = "Professional Affiliation 1";

            /// <summary>
            /// Professional Affiliation 2
            /// </summary>
            public const string ProfessionalAffiliation2 = "Professional Affiliation 2";

            /// <summary>
            /// Professional Affiliation 3
            /// </summary>
            public const string ProfessionalAffiliation3 = "Professional Affiliation 3";

            /// <summary>
            /// Professional Affiliation 4
            /// </summary>
            public const string ProfessionalAffiliation4 = "Professional Affiliation 4";

            /// <summary>
            /// Professional Affiliation 5
            /// </summary>
            public const string ProfessionalAffiliation5 = "Professional Affiliation 5";

            /// <summary>
            /// Professional Affiliation 6
            /// </summary>
            public const string ProfessionalAffiliation6 = "Professional Affiliation 6";

            /// <summary>
            /// Professional Affiliation 7
            /// </summary>
            public const string ProfessionalAffiliation7 = "Professional Affiliation 7";

            /// <summary>
            /// Professional Affiliation 8
            /// </summary>
            public const string ProfessionalAffiliation8 = "Professional Affiliation 8";

            /// <summary>
            /// Professional Affiliation 9
            /// </summary>
            public const string ProfessionalAffiliation9 = "Professional Affiliation 9";

            /// <summary>
            /// Professional Affiliation 10
            /// </summary>
            public const string ProfessionalAffiliation10 = "Professional Affiliation 10";

            /// <summary>
            /// Media Items
            /// </summary>
            public const string MediaItems = "Media Items";

            /// <summary>
            /// Deleted In Cactus
            /// </summary>
            public const string DeletedInCactus = "Deleted In Cactus";

            public const string RelatedContentPod = "Related Content Pod";
            public const string PhotoGallery = "Photo Gallery";
            public const string ContentBlock = "Content Block";
            public const string FeaturePod = "Feature Pod";
            public const string EnableInPageLink = "Enable In Page Link";

            public const string AcademicAffiliations1 = "Academic Affiliations 1";
            public const string AcademicAffiliations2 = "Academic Affiliations 2";
            public const string AcademicAffiliations3 = "Academic Affiliations 3";
            public const string AcademicAffiliations4 = "Academic Affiliations 4";
            public const string AcademicAffiliations5 = "Academic Affiliations 5";
            public const string AcademicAffiliations6 = "Academic Affiliations 6";
            public const string AcademicAffiliations7 = "Academic Affiliations 7";

        }

        /// <summary>
        /// Media Item
        /// </summary>
        public struct Media
        {
            /// <summary>
            /// Publish Date
            /// </summary>
            public const string PublishDate = "Publish Date";

            /// <summary>
            /// Media Title
            /// </summary>
            public const string MediaTitle = "Media Title";

            /// <summary>
            /// Media Link
            /// </summary>
            public const string MediaLink = "Media Link";

            /// <summary>
            /// Media Text
            /// </summary>
            public const string MediaText = "Media Text";

            /// <summary>
            /// Publisher Name
            /// </summary>
            public const string PublisherName = "Publisher Name";

        }

        /// <summary>
        /// Media Item
        /// </summary>
        public struct Specialty
        {
            /// <summary>
            /// Publish Date
            /// </summary>
            public const string Name = "Name";

            /// <summary>
            /// Cactus Id
            /// </summary>
            public const string CactusId = "CactusId";

        }
    }
}