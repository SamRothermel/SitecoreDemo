# SitecoreDemo
This is a demo build of a Sitecore 9 site using the helix design principles. Includes several basic components, templates, and a simple site search feature.

This project uses Hedgehog TDS to manage templates, which can be downloaded from here https://www.teamdevelopmentforsitecore.com/Download/TDS-Classic

Aside from that an instance of Sitecore 9.3 needs to be installed on the computer and the project's build needs to be set as a .NET library build to the the folder containing the instance of that site.
Should be something like: C:\inetpub\wwwroot\{sitecore-site-name}\

In addition, to use the site search, an index named sitecore_web_index needs to be created in the local instance of SOLR and after pages have been added to the site, the indexing tool within Sitecore will
need to run to build those indexes.

The Blog import tool under DevTools is meant to take in an XML formatted document and translate those blog items into a Sitecore formatted blog items. However this tool is incomplete.
