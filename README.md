
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]



<!-- PROJECT LOGO -->
<br />
<p align="center">
  <h3 align="center">Claytondus.ShippyPro</h3>

  <p align="center">
    An unofficial .NET wrapper for the <a href="https://www.ShippyPro.com">ShippyPro</a> API.
    <br />
    <a href="https://github.com/claytondus/Claytondus.ShippyPro/issues">Report Bug</a>
    ·
    <a href="https://github.com/claytondus/Claytondus.ShippyPro/issues">Request Feature</a>
  </p>
</p>



<!-- ABOUT THE PROJECT -->
## About The Project

ShippyPro is a multi-carrier shipping services API.  We use it at [Agonswim.com](https://www.agonswim.com) to generate shipping labels and track packages.  This project is a typed async API wrapper for .NET Standard.

### Built With

* [JetBrains Rider](https://jetbrains.com/rider)
* [Flurl](https://flurl.dev)


## Usage

1. Get an account and API key at [https://ShippyPro.com](https://https://app.ShippyPro.com/app/login/register)
2. Clone the repo
   ```sh
   dotnet add package Claytondus.ShippyPro
   ```
3. Instantiate the client
   ```C#
   var apiKey = "....";
   var client = new ShippyProClient(apiKey);
   ```
   You may also pass in an ILogger to log requests and responses:
   ```C#
   var client = new ShippyProClient(apiKey, logger:logger);
   ```
4. Call the API
   ```C#
   var request = new PutOrder
   {
       Params = parms
   };
   var response = await client.PutOrder(request);
   ```

### API Support
* PutOrder
* GetRates
* Ship

Additional APIs are supported upon request.



<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request



<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE` for more information.



<!-- CONTACT -->
## Contact

I AM NOT AFFILIATED WITH ShippyPro.  For questions about their service please contact them at https://www.shippypro.com/contact-us.html.

Clayton Davis - cd@ae4ax.net

Project Link: [https://github.com/claytondus/Claytondus.ShippyPro](https://github.com/claytondus/Claytondus.ShippyPro)



<!-- ACKNOWLEDGEMENTS -->
## Acknowledgements
* [ShippyPro](https://www.shippypro.com)



<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/claytondus/Claytondus.ShippyPro.svg?style=for-the-badge
[contributors-url]: https://github.com/claytondus/Claytondus.ShippyPro/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/claytondus/Claytondus.ShippyPro.svg?style=for-the-badge
[forks-url]: https://github.com/claytondus/Claytondus.ShippyPro/network/members
[stars-shield]: https://img.shields.io/github/stars/claytondus/Claytondus.ShippyPro.svg?style=for-the-badge
[stars-url]: https://github.com/claytondus/Claytondus.ShippyPro/stargazers
[issues-shield]: https://img.shields.io/github/issues/claytondus/Claytondus.ShippyPro.svg?style=for-the-badge
[issues-url]: https://github.com/claytondus/Claytondus.ShippyPro/issues
[license-shield]: https://img.shields.io/github/license/claytondus/Claytondus.ShippyPro.svg?style=for-the-badge
[license-url]: https://github.com/claytondus/Claytondus.ShippyPro/blob/master/LICENSE
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/claytond
