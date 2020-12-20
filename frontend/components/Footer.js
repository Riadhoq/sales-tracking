import styles from "../styles/Home.module.css";
import React from "react";

export const Footer = () => {
  return (
    <footer className={styles.footer}>
      <a
        href="https://github.com/Riadhoq"
        target="_blank"
        rel="noopener noreferrer"
      >
        Created by{" "}
        <img
          src="/riadhoq-logo.svg"
          alt="Riadul Hoque Logo"
          className={styles.logo}
        />
      </a>
    </footer>
  );
};
