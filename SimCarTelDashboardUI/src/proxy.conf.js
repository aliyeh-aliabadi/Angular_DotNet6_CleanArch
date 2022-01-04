const PROXY_CONFIG = [
  {
    context: [
      "/serverlogs",
    ],
    target: "https://localhost:7201",
    secure: false
  }
]

module.exports = PROXY_CONFIG;
