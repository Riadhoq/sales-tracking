module.exports = {
  env: {
    apiBaseUrl:
      process.env.NODE_ENV === "development"
        ? "http://localhost:5000/api"
        : process.env.API_BASE,
  },
};
