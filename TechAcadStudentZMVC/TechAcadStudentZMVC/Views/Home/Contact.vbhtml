﻿@Code
    ViewData("Title") = "Contact"
End Code

<h2>@ViewData("Title").</h2>
<h3>@ViewData("Message")</h3>

<address>
    310SW 4th St. 412<br />
    Portland, WA 98052-6399<br />
    <abbr title="Phone">P:</abbr>
    503.206.6916
</address>

<address>
    <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
    <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    <small>Contact information last updated: @DateTime.Now</small>
</address>
