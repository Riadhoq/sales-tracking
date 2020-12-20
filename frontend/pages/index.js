import Head from "next/head";
import Link from "next/link";
import styles from "../styles/Home.module.css";

export default function Home() {
  return (
    <div className={styles.container}>
      <Head>
        <title>Sales Tracking App</title>
        <link rel="icon" href="/favicon.ico" />
      </Head>
      <main className={styles.main}>
        <h1 className={styles.title}>BeSpoked Bikes</h1>

        <div className={styles.grid}>
          <Link href="/salespeople">
            <a className={styles.card}>
              <h3>Salesperson Portal &rarr;</h3>
              <p>See or edit a list of all Salespeople</p>
            </a>
          </Link>
          <Link href="/products">
            <a className={styles.card}>
              <h3>Product Portal &rarr;</h3>
              <p>View and edit all Products!</p>
            </a>
          </Link>

          <Link href="/customers">
            <a className={styles.card}>
              <h3>Customer Portal &rarr;</h3>
              <p>View existing Customers</p>
            </a>
          </Link>

          <Link href="/sales">
            <a className={styles.card}>
              <h3>Sales &rarr;</h3>
              <p>View all Sales with details</p>
            </a>
          </Link>
        </div>
      </main>
    </div>
  );
}
